# Installation

## 1. Release herunterladen

Laden Sie `winauth-cli-mono.zip` vom [aktuellen Release](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) herunter und entpacken Sie es:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono-Runtime installieren

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** Die CLI läuft auch mit dem unter Windows bereits vorhandenen .NET Framework — Mono wird nur für Linux/macOS benötigt.

## 3. Prüfen

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Bestätigt funktionierend auf ARM64 Linux (Ubuntu, via `mono-runtime`) und macOS (via Homebrew `mono`).
