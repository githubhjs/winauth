# 安装

## 1. 获取发行版

从[最新发行版](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest)下载 `winauth-cli-mono.zip` 并解压:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. 安装 Mono 运行时

**Linux(Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS(Homebrew):**
```sh
brew install mono
```

**Windows:** Windows 自带标准 .NET Framework,可直接运行此 CLI——Mono 仅在 Linux/macOS 上需要安装。

## 3. 验证安装

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

已在 ARM64 Linux(Ubuntu,使用 `mono-runtime`)和 macOS(使用 Homebrew 的 `mono`)上确认可正常运行。
