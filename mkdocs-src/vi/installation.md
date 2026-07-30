# Cài đặt

## 1. Tải bản phát hành

Tải `winauth-cli-mono.zip` từ [bản phát hành mới nhất](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) và giải nén:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Cài đặt Mono runtime

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI cũng chạy được với .NET Framework tiêu chuẩn đã có sẵn trên Windows — Mono chỉ cần thiết cho Linux/macOS.

## 3. Kiểm tra

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

Đã xác nhận hoạt động trên Linux ARM64 (Ubuntu, qua `mono-runtime`) và macOS (qua Homebrew `mono`).
