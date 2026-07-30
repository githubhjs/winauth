# Sử dụng CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Tùy chọn toàn cục:

| Tùy chọn | Mô tả |
|---|---|
| `--file PATH` | Đường dẫn đến tệp XML của kho lưu trữ (mặc định `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Mật khẩu kho lưu trữ, nếu đã mã hóa. Nên dùng biến môi trường `WINAUTH_PASSWORD` thay vì truyền trên dòng lệnh — tránh lộ mật khẩu trong danh sách tiến trình. |

## Các lệnh

| Lệnh | Mô tả |
|---|---|
| `list` | Liệt kê tất cả các mục trong kho lưu trữ |
| `code NAME\|ID` | Hiển thị mã TOTP/HOTP/Steam Guard hiện tại của một mục |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Thêm thủ công một mục mới |
| `import --uri otpauth://...` | Nhập một mục từ URI `otpauth://` chuẩn |
| `show NAME\|ID` | Hiển thị URI `otpauth://` của một mục |
| `rename NAME\|ID NEW_NAME` | Đổi tên một mục |
| `remove NAME\|ID` | Xóa một mục |
| `sync NAME\|ID COUNTER` | Đặt giá trị bộ đếm HOTP |
| `export DESTINATION` | Xuất kho lưu trữ |
| `passwd --new-password VALUE` | Mã hóa, đổi khóa, hoặc giải mã kho lưu trữ |

## Ví dụ

```sh
# Nhập từ URI otpauth:// (ví dụ từ bản xuất mã QR)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Thêm một mục Steam Guard trực tiếp từ bí mật Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Lấy mã hiện tại
./winauth-cli code steam

# Liệt kê mọi thứ trong kho lưu trữ
./winauth-cli list

# Mã hóa kho lưu trữ bằng mật khẩu (nên dùng WINAUTH_PASSWORD thay vì --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Vị trí kho lưu trữ

Theo mặc định, kho lưu trữ được lưu tại `~/.config/winauth-cli/winauth.xml`. Hãy giữ quyền truy cập tệp này chặt chẽ (`chmod 600`), vì nó chứa các bí mật xác thực, bất kể kho lưu trữ có được mã hóa hay không.
