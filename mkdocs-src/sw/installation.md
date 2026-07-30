# Usakinishaji

## 1. Pata toleo

Pakua `winauth-cli-mono.zip` kutoka [toleo jipya zaidi](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) na uifungue:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Sakinisha mazingira ya utekelezaji ya Mono

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI hii pia hufanya kazi na .NET Framework ya kawaida iliyopo tayari kwenye Windows — Mono inahitajika tu kwa Linux/macOS.

## 3. Thibitisha

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Imethibitishwa kufanya kazi kwenye Linux ARM64 (Ubuntu, kupitia `mono-runtime`) na macOS (kupitia Homebrew `mono`).
