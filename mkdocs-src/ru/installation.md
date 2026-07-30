# Установка

## 1. Получить релиз

Скачайте `winauth-cli-mono.zip` из [последнего релиза](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) и распакуйте:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Установить среду выполнения Mono

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI также работает со стандартным .NET Framework, уже присутствующим в Windows — Mono нужен только для Linux/macOS.

## 3. Проверка

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Подтверждена работа на ARM64 Linux (Ubuntu, через `mono-runtime`) и macOS (через Homebrew `mono`).
