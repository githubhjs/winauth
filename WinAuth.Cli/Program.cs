using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinAuth.Cli {
  internal static class Program {
    static int Main(string[] args) {
      try {
        var a = new List<string>(args); string file = Option(a, "--file") ?? DefaultFile(); string password = Option(a, "--password") ?? Environment.GetEnvironmentVariable("WINAUTH_PASSWORD");
        if (a.Count == 0 || a[0] == "help" || a[0] == "--help") { Help(); return 0; }
        string command = a[0]; a.RemoveAt(0); var vault = Vault.Load(file, password);
        if (command == "list") foreach (var e in vault.Entries) Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.Id, e.Kind, e.Issuer, e.Name);
        else if (command == "code") { var e = Find(vault, Need(a,0,"name or id")); Console.WriteLine(Otp.Code(e)); vault.Save(file,password); }
        else if (command == "add" || command == "import") { Add(vault,a); vault.Save(file,password); }
        else if (command == "remove") { vault.Entries.Remove(Find(vault,Need(a,0,"name or id"))); vault.Save(file,password); }
        else if (command == "rename") { Find(vault,Need(a,0,"name or id")).Name=Need(a,1,"new name"); vault.Save(file,password); }
        else if (command == "show") { var e=Find(vault,Need(a,0,"name or id")); string kind=e.Kind=="steam"?"totp":e.Kind; string name=e.Kind=="steam"&&!e.Name.StartsWith("Steam:",StringComparison.OrdinalIgnoreCase)?"Steam:"+e.Name:e.Name; Console.WriteLine("otpauth://{0}/{1}?secret={2}&issuer={3}&digits={4}&period={5}&counter={6}&algorithm={7}",kind,Uri.EscapeDataString(name),e.Secret,Uri.EscapeDataString(e.Issuer??""),e.Digits,e.Period,e.Counter,e.Algorithm); }
        else if (command == "export") { string dest=Need(a,0,"destination"); File.Copy(file,dest,true); }
        else if (command == "passwd") { string next=Option(a,"--new-password"); vault.Save(file,next); }
        else if (command == "sync") { var e=Find(vault,Need(a,0,"name or id")); if(e.Kind=="hotp") e.Counter=long.Parse(Need(a,1,"counter")); vault.Save(file,password); }
        else throw new ArgumentException("Unknown command: "+command);
        return 0;
      } catch(Exception ex) { Console.Error.WriteLine("winauth-cli: "+ex.Message); return 1; }
    }
    static void Add(Vault v,List<string> a) {
      string uri=Option(a,"--uri"); var e=new Entry {Id=Guid.NewGuid().ToString("N"),Kind=(Option(a,"--type")??"totp").ToLowerInvariant(),Name=Option(a,"--name"),Issuer=Option(a,"--issuer")??"",Secret=Option(a,"--secret"),Algorithm=(Option(a,"--algorithm")??"SHA1").ToUpperInvariant()};
      if(uri==null && a.Count>0 && a[0].StartsWith("otpauth://")) {uri=a[0];a.RemoveAt(0);} if(uri!=null) ParseUri(uri,e);
      int n; long l; if(int.TryParse(Option(a,"--digits"),out n))e.Digits=n;if(int.TryParse(Option(a,"--period"),out n))e.Period=n;if(long.TryParse(Option(a,"--counter"),out l))e.Counter=l;
      if(e.Kind!="totp"&&e.Kind!="hotp"&&e.Kind!="steam")throw new ArgumentException("Unsupported authenticator type: "+e.Kind);
      if(e.Kind=="steam"){e.Issuer="Steam";e.Digits=5;e.Period=30;e.Algorithm="SHA1";}
      if(string.IsNullOrEmpty(e.Name)||string.IsNullOrEmpty(e.Secret))throw new ArgumentException("add requires --name and --secret, or --uri"); Otp.Base32(e.Secret); v.Entries.Add(e);
    }
    static void ParseUri(string text,Entry e) { var u=new Uri(text); if(u.Scheme!="otpauth")throw new ArgumentException("Only otpauth URIs are supported");e.Kind=u.Host.ToLowerInvariant();e.Name=Uri.UnescapeDataString(u.AbsolutePath.TrimStart('/'));foreach(string p in u.Query.TrimStart('?').Split('&')){var x=p.Split(new[]{'='},2);if(x.Length<2)continue;string k=x[0],val=Uri.UnescapeDataString(x[1].Replace("+"," "));int n;long l;if(k=="secret")e.Secret=val;else if(k=="issuer")e.Issuer=val;else if(k=="algorithm")e.Algorithm=val.ToUpperInvariant();else if(k=="digits"&&int.TryParse(val,out n))e.Digits=n;else if(k=="period"&&int.TryParse(val,out n))e.Period=n;else if(k=="counter"&&long.TryParse(val,out l))e.Counter=l;} if(string.Equals(e.Issuer,"Steam",StringComparison.OrdinalIgnoreCase)||e.Name.StartsWith("Steam:",StringComparison.OrdinalIgnoreCase))e.Kind="steam";}
    static Entry Find(Vault v,string key){var matches=v.Entries.Where(x=>x.Id==key||string.Equals(x.Name,key,StringComparison.OrdinalIgnoreCase)).ToList();if(matches.Count!=1)throw new ArgumentException(matches.Count==0?"Authenticator not found":"Name is ambiguous; use its id");return matches[0];}
    static string Option(List<string>a,string key){int i=a.IndexOf(key);if(i<0)return null;if(i+1>=a.Count)throw new ArgumentException(key+" needs a value");string v=a[i+1];a.RemoveRange(i,2);return v;} static string Need(List<string>a,int i,string what){if(i>=a.Count)throw new ArgumentException("Missing "+what);return a[i];}
    static string DefaultFile(){string home=Environment.GetFolderPath(Environment.SpecialFolder.Personal);return Path.Combine(home,".config","winauth","winauth.xml");}
    static void Help(){Console.WriteLine(@"WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
Commands:
  list
  code NAME|ID
  add --name NAME --secret BASE32 [--type totp|hotp|steam] [--issuer TEXT]
      [--digits N] [--period N] [--counter N] [--algorithm SHA1|SHA256|SHA512]
  import --uri otpauth://...
  show NAME|ID                 print an otpauth URI
  rename NAME|ID NEW_NAME
  remove NAME|ID
  sync NAME|ID COUNTER         set an HOTP counter
  export DESTINATION
  passwd --new-password VALUE  encrypt, re-key, or decrypt the vault

Set WINAUTH_PASSWORD instead of exposing a password in the process list.");}
  }
}
