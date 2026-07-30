# इन्स्टॉलेशन

## 1. रिलीज मिळवा

[नवीनतम रिलीज](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) मधून `winauth-cli-mono.zip` डाउनलोड करा आणि एक्स्ट्रॅक्ट करा:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono रनटाइम इन्स्टॉल करा

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** Windows वर आधीपासून असलेल्या स्टँडर्ड .NET Framework सोबतही CLI चालते — Mono फक्त Linux/macOS साठी आवश्यक आहे.

## 3. पडताळणी करा

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux (Ubuntu, `mono-runtime` द्वारे) आणि macOS (Homebrew `mono` द्वारे) वर काम करत असल्याची पुष्टी झाली आहे.
