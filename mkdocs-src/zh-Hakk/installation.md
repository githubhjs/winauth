# 安裝

## 1. 下載版本

從 [最新版本](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) 下載 `winauth-cli-mono.zip`，解壓縮。

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. 安裝 Mono runtime

**Linux (Ubuntu/Debian)：**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew)：**
```sh
brew install mono
```

**Windows：** 脈隻 CLI 在 Windows 頂高做得用系統本底个 .NET Framework 就跑得起來。Mono 只有 Linux/macOS 正需要。

## 3. 檢查

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

已經確認在 ARM64 Linux（用 `mono-runtime`）摎 macOS（用 Homebrew 个 `mono`）頂高都行得好好。
