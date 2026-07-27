using System;
using System.Security.Cryptography;
using System.Text;

namespace WinAuth.Cli {
  internal static class Otp {
    const string SteamAlphabet = "23456789BCDFGHJKMNPQRTVWXY";

    internal static byte[] Base32(string value) {
      value = value.Trim().TrimEnd('=').Replace(" ", "").ToUpperInvariant();
      const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
      int buffer = 0, bits = 0; var output = new System.Collections.Generic.List<byte>();
      foreach (char c in value) { int n = alphabet.IndexOf(c); if (n < 0) throw new ArgumentException("Invalid base32 secret"); buffer = (buffer << 5) | n; bits += 5; if (bits >= 8) { bits -= 8; output.Add((byte)(buffer >> bits)); buffer &= (1 << bits) - 1; } }
      return output.ToArray();
    }
    internal static string Code(Entry e) {
      long counter = e.Kind == "hotp" ? e.Counter : (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds / e.Period;
      byte[] msg = BitConverter.GetBytes(counter); if (BitConverter.IsLittleEndian) Array.Reverse(msg);
      byte[] hash;
      using (HMAC h = CreateHmac(e.Algorithm, Base32(e.Secret))) {
        hash = h.ComputeHash(msg);
      }
      int binary = Truncate(hash);
      if (e.Kind == "steam") return SteamCode(binary);
      string code = (binary % (int)Math.Pow(10, e.Digits)).ToString(new string('0', e.Digits)); if (e.Kind == "hotp") e.Counter++; return code;
    }
    static int Truncate(byte[] hash) {
      int o = hash[hash.Length - 1] & 15;
      return ((hash[o]&127)<<24)|(hash[o+1]<<16)|(hash[o+2]<<8)|hash[o+3];
    }
    static string SteamCode(int binary) {
      uint value = (uint)binary;
      StringBuilder code = new StringBuilder();
      for (int i = 0; i < 5; i++) {
        code.Append(SteamAlphabet[(int)(value % SteamAlphabet.Length)]);
        value /= (uint)SteamAlphabet.Length;
      }
      return code.ToString();
    }
    static HMAC CreateHmac(string algorithm, byte[] key) {
      if (algorithm == "SHA256") return new HMACSHA256(key);
      if (algorithm == "SHA512") return new HMACSHA512(key);
      if (algorithm == "SHA1") return new HMACSHA1(key);
      throw new ArgumentException("Unsupported HMAC algorithm: " + algorithm);
    }
  }
}
