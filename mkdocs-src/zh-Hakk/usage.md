# CLI 用法

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

共通選項：

| 選項 | 說明 |
|---|---|
| `--file PATH` | vault XML 檔案个路徑（預設 `~/.config/winauth-cli/winauth.xml`） |
| `--password VALUE` | vault 有加密个時節用个密碼。用 `WINAUTH_PASSWORD` 這隻環境變數來代替直接寫在命令列較好——恁樣密碼就毋會留在 process 清單頂高 |

## 指令

| 指令 | 說明 |
|---|---|
| `list` | 列出 vault 底背全部个帳目 |
| `code NAME\|ID` | 顯示脈隻帳目這下个 TOTP/HOTP/Steam Guard 代碼 |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | 手動新增一隻帳目 |
| `import --uri otpauth://...` | 從標準个 `otpauth://` URI 匯入帳目 |
| `show NAME\|ID` | 顯示脈隻帳目个 `otpauth://` URI |
| `rename NAME\|ID NEW_NAME` | 改脈隻帳目个名 |
| `remove NAME\|ID` | 刪掉脈隻帳目 |
| `sync NAME\|ID COUNTER` | 設定 HOTP 个計數器數值 |
| `export DESTINATION` | 匯出 vault |
| `passwd --new-password VALUE` | 設定、換掉，抑係取消 vault 个加密 |

## 例：

```sh
# 從 otpauth:// URI 匯入（比方講從 QR code 匯出來个）
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# 用 Base32 秘密直接加一隻 Steam Guard 帳目
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# 拿這下个代碼
./winauth-cli code steam

# 列出 vault 底背所有个帳目
./winauth-cli list

# 用密碼加密 vault（用 WINAUTH_PASSWORD 較好，毋好用 --password）
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Vault 位置

預設 vault 存在 `~/.config/winauth-cli/winauth.xml`。無論 vault 本身有無加密，這隻檔案底背都有 authenticator 个秘密資料，所以檔案个權限一定爱設嚴（`chmod 600`）。
