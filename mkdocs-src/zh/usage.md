# CLI 使用说明

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

全局选项:

| 选项 | 说明 |
|---|---|
| `--file PATH` | 保险库 XML 文件路径(默认 `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | 保险库密码(如已加密)。建议使用环境变量 `WINAUTH_PASSWORD`,而不是直接在命令行传入,以避免密码出现在系统进程列表中。 |

## 命令列表

| 命令 | 说明 |
|---|---|
| `list` | 列出保险库中的所有条目 |
| `code NAME\|ID` | 显示某条目当前的 TOTP/HOTP/Steam Guard 验证码 |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | 手动添加一个条目 |
| `import --uri otpauth://...` | 从标准 `otpauth://` URI 导入条目 |
| `show NAME\|ID` | 显示某条目的 `otpauth://` URI |
| `rename NAME\|ID NEW_NAME` | 重命名某条目 |
| `remove NAME\|ID` | 删除某条目 |
| `sync NAME\|ID COUNTER` | 设置 HOTP 计数器值 |
| `export DESTINATION` | 导出保险库 |
| `passwd --new-password VALUE` | 加密、重新设置密钥,或解密保险库 |

## 示例

```sh
# 从 otpauth:// URI 导入(例如来自二维码的导出结果)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# 直接用 Base32 密钥添加 Steam Guard 条目
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# 获取当前验证码
./winauth-cli code steam

# 列出保险库中的所有内容
./winauth-cli list

# 为保险库加密(尽量用 WINAUTH_PASSWORD 代替 --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## 保险库文件位置

默认保存在 `~/.config/winauth-cli/winauth.xml`。无论保险库本身是否加密,该文件都包含验证器密钥,请务必将其权限设置严格(`chmod 600`)。
