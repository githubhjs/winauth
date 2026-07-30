# CLI ব্যবহার

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

গ্লোবাল অপশন:

| অপশন | বর্ণনা |
|---|---|
| `--file PATH` | ভল্ট XML ফাইলের পাথ (ডিফল্ট `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | ভল্ট এনক্রিপ্ট করা থাকলে তার পাসওয়ার্ড। কমান্ড লাইনে দেওয়ার বদলে এনভায়রনমেন্ট ভেরিয়েবল `WINAUTH_PASSWORD` ব্যবহার করা ভালো — এতে প্রসেস তালিকায় পাসওয়ার্ড প্রকাশ পায় না। |

## কমান্ডসমূহ

| কমান্ড | বর্ণনা |
|---|---|
| `list` | ভল্টের সব এন্ট্রি তালিকাভুক্ত করে |
| `code NAME\|ID` | কোনো এন্ট্রির বর্তমান TOTP/HOTP/Steam Guard কোড দেখায় |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | ম্যানুয়ালি একটি নতুন এন্ট্রি যোগ করে |
| `import --uri otpauth://...` | স্ট্যান্ডার্ড `otpauth://` URI থেকে একটি এন্ট্রি ইম্পোর্ট করে |
| `show NAME\|ID` | কোনো এন্ট্রির `otpauth://` URI দেখায় |
| `rename NAME\|ID NEW_NAME` | একটি এন্ট্রির নাম পরিবর্তন করে |
| `remove NAME\|ID` | একটি এন্ট্রি সরিয়ে দেয় |
| `sync NAME\|ID COUNTER` | একটি HOTP কাউন্টার মান সেট করে |
| `export DESTINATION` | ভল্ট এক্সপোর্ট করে |
| `passwd --new-password VALUE` | ভল্ট এনক্রিপ্ট, রি-কি, বা ডিক্রিপ্ট করে |

## উদাহরণ

```sh
# একটি otpauth:// URI থেকে ইম্পোর্ট (যেমন QR কোড এক্সপোর্ট থেকে)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 সিক্রেট থেকে সরাসরি একটি Steam Guard এন্ট্রি যোগ করুন
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# বর্তমান কোড পান
./winauth-cli code steam

# ভল্টের সবকিছু তালিকাভুক্ত করুন
./winauth-cli list

# পাসওয়ার্ড দিয়ে ভল্ট এনক্রিপ্ট করুন (সম্ভব হলে --password-এর বদলে WINAUTH_PASSWORD ব্যবহার করুন)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## ভল্টের অবস্থান

ডিফল্টভাবে, ভল্ট `~/.config/winauth-cli/winauth.xml`-এ সংরক্ষিত হয়। ভল্ট নিজে এনক্রিপ্টেড থাকুক বা না থাকুক, এতে অথেনটিকেটর সিক্রেট থাকে বলে এই ফাইলের অনুমতি কঠোর রাখুন (`chmod 600`)।
