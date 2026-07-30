# Installazione

## 1. Scaricare la release

Scarica `winauth-cli-mono.zip` dall'[ultima release](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) ed estrailo:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Installare il runtime Mono

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** il CLI funziona anche con il .NET Framework standard già presente su Windows — Mono serve solo per Linux/macOS.

## 3. Verifica

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Funzionamento confermato su Linux ARM64 (Ubuntu, via `mono-runtime`) e macOS (via Homebrew `mono`).
