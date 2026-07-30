# CLI の使い方

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

グローバルオプション:

| オプション | 説明 |
|---|---|
| `--file PATH` | ボールトXMLファイルのパス(既定値: `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | ボールトが暗号化されている場合のパスワード。コマンドライン引数よりも環境変数 `WINAUTH_PASSWORD` を使う方が、プロセス一覧にパスワードが露出しないため安全です。 |

## コマンド一覧

| コマンド | 説明 |
|---|---|
| `list` | ボールト内の全エントリを一覧表示 |
| `code NAME\|ID` | エントリの現在の TOTP/HOTP/Steam Guard コードを表示 |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | 新規エントリを手動で追加 |
| `import --uri otpauth://...` | 標準の `otpauth://` URI からエントリをインポート |
| `show NAME\|ID` | エントリの `otpauth://` URI を表示 |
| `rename NAME\|ID NEW_NAME` | エントリ名を変更 |
| `remove NAME\|ID` | エントリを削除 |
| `sync NAME\|ID COUNTER` | HOTP のカウンタ値を設定 |
| `export DESTINATION` | ボールトをエクスポート |
| `passwd --new-password VALUE` | ボールトの暗号化・鍵の再設定・復号 |

## 使用例

```sh
# otpauth:// URI からインポート(例: QRコードのエクスポート)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 シークレットから直接 Steam Guard エントリを追加
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# 現在のコードを取得
./winauth-cli code steam

# ボールトの内容を一覧表示
./winauth-cli list

# ボールトをパスワードで暗号化(可能な限り --password より WINAUTH_PASSWORD を使用)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## ボールトの保存場所

既定では `~/.config/winauth-cli/winauth.xml` に保存されます。暗号化の有無にかかわらず認証シークレットを含むため、このファイルの権限は厳格に(`chmod 600`)保ってください。
