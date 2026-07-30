# Installation

## 1. Get the release

Download `winauth-cli-mono.zip` from the [latest release](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) and extract it:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Install the Mono runtime

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** the CLI also runs under the standard .NET Framework already present on Windows — Mono is only needed for Linux/macOS.

## 3. Verify

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Confirmed working on ARM64 Linux (Ubuntu, via `mono-runtime`) and macOS (via Homebrew `mono`).
