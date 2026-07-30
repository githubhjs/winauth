# Instalación

## 1. Obtener la versión

Descarga `winauth-cli-mono.zip` desde la [última versión](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) y extráelo:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Instalar el runtime de Mono

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** el CLI también funciona con el .NET Framework estándar ya presente en Windows — Mono solo es necesario para Linux/macOS.

## 3. Verificar

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Confirmado funcionando en Linux ARM64 (Ubuntu, vía `mono-runtime`) y macOS (vía Homebrew `mono`).
