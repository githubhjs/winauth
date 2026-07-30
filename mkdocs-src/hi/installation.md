# इंस्टॉलेशन

## 1. रिलीज़ प्राप्त करें

[नवीनतम रिलीज़](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) से `winauth-cli-mono.zip` डाउनलोड करें और एक्सट्रैक्ट करें:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono रनटाइम इंस्टॉल करें

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI, Windows में पहले से मौजूद स्टैंडर्ड .NET Framework के साथ भी चलता है — Mono सिर्फ़ Linux/macOS के लिए ज़रूरी है।

## 3. सत्यापन करें

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux (Ubuntu, `mono-runtime` के ज़रिए) और macOS (Homebrew `mono` के ज़रिए) पर काम करना कन्फ़र्म किया गया है।
