# winauth-cli

[WinAuth](https://github.com/winauth/winauth)-এর একটি ক্রস-প্ল্যাটফর্ম, GUI-বিহীন ফর্ক, যা Mono-এর মাধ্যমে Linux, macOS ও Windows-এ এক্সপোর্ট করা অথেনটিকেটর সিক্রেট ব্যবহার করতে দেয় — Windows GUI-এর প্রয়োজন নেই।

সাধারণ TOTP/HOTP-এর পাশাপাশি Steam Guard-এর ৫-অক্ষরের কোড ফরম্যাটও সমর্থন করে। এন্ট্রিগুলো একটি লোকাল XML ভল্টে সংরক্ষিত হয়, যা ঐচ্ছিকভাবে পাসওয়ার্ড দিয়ে এনক্রিপ্ট করা যায়।

## দ্রুত শুরু

সর্বশেষ রিলিজ ডাউনলোড করুন:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

প্রতিটি প্ল্যাটফর্মে Mono সেটআপের জন্য [ইনস্টলেশন](installation.md) দেখুন, এবং সম্পূর্ণ কমান্ড রেফারেন্সের জন্য [CLI ব্যবহার](usage.md) দেখুন।

## এই ফর্কটি কেন তৈরি হয়েছে

মূল WinAuth একটি Windows Forms GUI অ্যাপ্লিকেশন। এই ফর্কটি অথেনটিকেটর/TOTP/HOTP/Steam Guard লজিককে `WinAuth.Cli`-তে আলাদা করে, যা একটি Mono-সামঞ্জস্যপূর্ণ কমান্ড-লাইন টুল, যাতে এক্সপোর্ট করা অথেনটিকেটর সিক্রেট (যেমন `.maFile`, WinAuth XML এক্সপোর্ট, বা যেকোনো `otpauth://` URI থেকে) সার্ভার, CI, বা Windows নয় এমন মেশিনে GUI ছাড়াই ব্যবহার করা যায় — ARM64 Linux ওয়ার্কস্টেশন এবং macOS উভয় ক্ষেত্রেই কাজ করে বলে যাচাই করা হয়েছে।

মূল Windows GUI-এর সোর্স কোড রিপোজিটরিতে উৎস ও সামঞ্জস্যতার রেফারেন্স হিসেবে রাখা হয়েছে, তবে এই ফর্কের রক্ষণাবেক্ষণ করা লক্ষ্য হলো `WinAuth.Cli`।

## লেখক

এই ফর্কটি রক্ষণাবেক্ষণ করেন Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com))।
