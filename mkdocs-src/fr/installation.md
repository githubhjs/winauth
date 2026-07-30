# Installation

## 1. Récupérer la version

Téléchargez `winauth-cli-mono.zip` depuis la [dernière version](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) et extrayez-le :

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Installer le runtime Mono

**Linux (Ubuntu/Debian) :**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew) :**
```sh
brew install mono
```

**Windows :** le CLI fonctionne aussi avec le .NET Framework standard déjà présent sous Windows — Mono n'est nécessaire que pour Linux/macOS.

## 3. Vérifier

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Fonctionnement confirmé sur Linux ARM64 (Ubuntu, via `mono-runtime`) et macOS (via Homebrew `mono`).
