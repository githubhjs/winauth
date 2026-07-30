# Instalasi

## 1. Dapatkan rilis

Unduh `winauth-cli-mono.zip` dari [rilis terbaru](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) dan ekstrak:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Instal runtime Mono

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI ini juga berjalan dengan .NET Framework standar yang sudah ada di Windows — Mono hanya diperlukan untuk Linux/macOS.

## 3. Verifikasi

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Dikonfirmasi berjalan baik di Linux ARM64 (Ubuntu, via `mono-runtime`) dan macOS (via Homebrew `mono`).
