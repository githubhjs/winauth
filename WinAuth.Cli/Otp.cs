using System;
using System.Security.Cryptography;
using System.Text;

namespace WinAuth.Cli {
  internal static class Otp {
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
      HMAC h = e.Algorithm == "SHA256" ? (HMAC)new HMACSHA256(Base32(e.Secret)) : e.Algorithm == "SHA512" ? new HMACSHA512(Base32(e.Secret)) : new HMACSHA1(Base32(e.Secret));
      byte[] hash = h.ComputeHash(msg); int o = hash[hash.Length - 1] & 15; int binary = ((hash[o]&127)<<24)|(hash[o+1]<<16)|(hash[o+2]<<8)|hash[o+3];
      string code = (binary % (int)Math.Pow(10, e.Digits)).ToString(new string('0', e.Digits)); if (e.Kind == "hotp") e.Counter++; return code;
    }
  }
}
