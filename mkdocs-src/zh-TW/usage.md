# CLI 使用說明

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

全域選項:

| 選項 | 說明 |
|---|---|
| `--file PATH` | 保險箱 XML 檔案路徑(預設為 `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | 保險箱密碼(若已加密)。建議使用環境變數 `WINAUTH_PASSWORD` 而非在命令列直接帶入,以避免密碼出現在系統程序清單中。 |

## 指令列表

| 指令 | 說明 |
|---|---|
| `list` | 列出保險箱內所有項目 |
| `code NAME\|ID` | 顯示某項目目前的 TOTP/HOTP/Steam Guard 驗證碼 |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | 手動新增一個項目 |
| `import --uri otpauth://...` | 從標準 `otpauth://` URI 匯入一個項目 |
| `show NAME\|ID` | 顯示某項目的 `otpauth://` URI |
| `rename NAME\|ID NEW_NAME` | 重新命名某項目 |
| `remove NAME\|ID` | 移除某項目 |
| `sync NAME\|ID COUNTER` | 設定 HOTP 計數器數值 |
| `export DESTINATION` | 匯出保險箱 |
| `passwd --new-password VALUE` | 加密、重新設定金鑰,或解密保險箱 |

## 範例

```sh
# 從 otpauth:// URI 匯入(例如來自 QR code 的匯出結果)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# 直接用 Base32 密鑰新增 Steam Guard 項目
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# 取得目前驗證碼
./winauth-cli code steam

# 列出保險箱裡的所有項目
./winauth-cli list

# 為保險箱加密(盡量用 WINAUTH_PASSWORD 取代 --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## 保險箱檔案位置

預設儲存於 `~/.config/winauth-cli/winauth.xml`。不論保險箱本身是否加密,這個檔案都包含驗證器密鑰,請務必將權限設定嚴格(`chmod 600`)。
