# ఇన్‌స్టాలేషన్

## 1. విడుదలను పొందండి

[తాజా విడుదల](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) నుండి `winauth-cli-mono.zip`ను డౌన్‌లోడ్ చేసి ఎక్స్‌ట్రాక్ట్ చేయండి:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono రన్‌టైమ్‌ను ఇన్‌స్టాల్ చేయండి

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** Windowsలో ఇప్పటికే ఉన్న ప్రామాణిక .NET Framework తో కూడా CLI నడుస్తుంది — Mono Linux/macOS కోసం మాత్రమే అవసరం.

## 3. ధృవీకరించండి

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux (Ubuntu, `mono-runtime` ద్వారా) మరియు macOS (Homebrew `mono` ద్వారా) పై పనిచేస్తుందని నిర్ధారించబడింది.
