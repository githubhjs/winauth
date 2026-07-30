# Instalação

## 1. Obter o release

Baixe `winauth-cli-mono.zip` do [último release](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) e extraia:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Instalar o runtime Mono

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** o CLI também roda com o .NET Framework padrão já presente no Windows — o Mono só é necessário para Linux/macOS.

## 3. Verificar

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Confirmado funcionando em Linux ARM64 (Ubuntu, via `mono-runtime`) e macOS (via Homebrew `mono`).
