# 安裝

## 1. 取得發行版

從[最新發行版](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest)下載 `winauth-cli-mono.zip` 並解壓縮:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. 安裝 Mono 執行環境

**Linux(Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS(Homebrew):**
```sh
brew install mono
```

**Windows:** Windows 本身已內建標準 .NET Framework,可直接執行此 CLI——Mono 只有在 Linux/macOS 上才需要安裝。

## 3. 驗證安裝

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

已在 ARM64 Linux(Ubuntu,使用 `mono-runtime`)與 macOS(使用 Homebrew 的 `mono`)上確認可正常運作。
