# Kurulum

## 1. Sürümü indirin

[En son sürümden](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) `winauth-cli-mono.zip` dosyasını indirin ve çıkarın:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono çalışma zamanını kurun

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI, Windows'ta zaten mevcut olan standart .NET Framework ile de çalışır — Mono yalnızca Linux/macOS için gereklidir.

## 3. Doğrulama

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux'ta (Ubuntu, `mono-runtime` ile) ve macOS'ta (Homebrew `mono` ile) çalıştığı doğrulanmıştır.
