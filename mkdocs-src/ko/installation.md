# 설치

## 1. 릴리스 받기

[최신 릴리스](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest)에서 `winauth-cli-mono.zip`을 다운로드하여 압축을 풉니다:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono 런타임 설치

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** Windows에는 이미 표준 .NET Framework가 설치되어 있으므로 CLI가 그대로 실행됩니다 — Mono는 Linux/macOS에서만 필요합니다.

## 3. 확인

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux(Ubuntu, `mono-runtime` 사용)와 macOS(Homebrew `mono` 사용)에서 정상 동작 확인됨.
