# ইনস্টলেশন

## ১. রিলিজ সংগ্রহ করুন

[সর্বশেষ রিলিজ](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) থেকে `winauth-cli-mono.zip` ডাউনলোড করে এক্সট্র্যাক্ট করুন:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## ২. Mono রানটাইম ইনস্টল করুন

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI-টি Windows-এ আগে থেকেই থাকা স্ট্যান্ডার্ড .NET Framework দিয়েও চলে — Mono শুধু Linux/macOS-এর জন্য প্রয়োজন।

## ৩. যাচাই করুন

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux (Ubuntu, `mono-runtime`-এর মাধ্যমে) এবং macOS (Homebrew `mono`-এর মাধ্যমে) কাজ করে বলে নিশ্চিত করা হয়েছে।
