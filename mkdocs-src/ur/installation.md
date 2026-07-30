# تنصیب

## 1. ریلیز حاصل کریں

[تازہ ترین ریلیز](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) سے `winauth-cli-mono.zip` ڈاؤن لوڈ کریں اور اسے نکالیں:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono رن ٹائم انسٹال کریں

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** یہ CLI Windows میں پہلے سے موجود معیاری .NET Framework کے ساتھ بھی چلتا ہے — Mono صرف Linux/macOS کے لیے ضروری ہے۔

## 3. تصدیق کریں

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux (Ubuntu، `mono-runtime` کے ذریعے) اور macOS (Homebrew `mono` کے ذریعے) پر کام کرنے کی تصدیق ہو چکی ہے۔
