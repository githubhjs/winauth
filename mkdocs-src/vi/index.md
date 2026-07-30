# winauth-cli

Bản fork đa nền tảng, không có giao diện đồ họa của [WinAuth](https://github.com/winauth/winauth), dùng để chạy các bí mật xác thực (authenticator secrets) đã xuất trên Linux, macOS và Windows thông qua Mono — không cần giao diện GUI của Windows.

Hỗ trợ TOTP/HOTP thông thường, cùng với định dạng mã 5 ký tự của Steam Guard. Các mục được lưu trong một kho lưu trữ XML cục bộ, có thể mã hóa bằng mật khẩu.

## Bắt đầu nhanh

Tải phiên bản mới nhất:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Xem [Cài đặt](installation.md) để thiết lập Mono trên từng nền tảng, và [Sử dụng CLI](usage.md) để xem đầy đủ tham chiếu lệnh.

## Vì sao có bản fork này

WinAuth gốc là một ứng dụng GUI Windows Forms. Bản fork này tách logic xác thực/TOTP/HOTP/Steam Guard vào `WinAuth.Cli`, một công cụ dòng lệnh tương thích Mono, để các bí mật xác thực đã xuất (ví dụ từ `.maFile`, bản xuất XML của WinAuth, hoặc bất kỳ URI `otpauth://` nào) có thể được sử dụng không cần giao diện trên máy chủ, CI, hoặc các máy không chạy Windows — đã xác nhận hoạt động trên cả máy trạm Linux ARM64 và macOS.

Mã nguồn GUI Windows gốc vẫn được giữ trong kho mã để tham khảo về nguồn gốc và khả năng tương thích, nhưng `WinAuth.Cli` mới là mục tiêu được duy trì của bản fork này.

## Tác giả

Bản fork được duy trì bởi Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
