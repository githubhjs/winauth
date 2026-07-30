# நிறுவல்

## 1. வெளியீட்டைப் பெறவும்

[சமீபத்திய வெளியீட்டிலிருந்து](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) `winauth-cli-mono.zip` ஐ பதிவிறக்கி பிரித்தெடுக்கவும்:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono இயக்க நேரத்தை நிறுவவும்

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** Windows-இல் ஏற்கனவே உள்ள நிலையான .NET Framework உடனும் CLI இயங்கும் — Mono Linux/macOS-க்கு மட்டுமே தேவை.

## 3. சரிபார்க்கவும்

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux (Ubuntu, `mono-runtime` வழியாக) மற்றும் macOS (Homebrew `mono` வழியாக) இல் இயங்குவது உறுதி செய்யப்பட்டுள்ளது.
