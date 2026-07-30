# インストール

## 1. リリースを取得

[最新リリース](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) から `winauth-cli-mono.zip` をダウンロードして展開します:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono ランタイムをインストール

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** Windows には既定で .NET Framework が入っているため、Mono は不要です(Linux/macOS のみ必要)。

## 3. 動作確認

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux(Ubuntu、`mono-runtime` 使用)と macOS(Homebrew の `mono` 使用)で動作確認済みです。
