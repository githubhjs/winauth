# winauth-cli

[WinAuth](https://github.com/winauth/winauth) をフォークした、GUIなしのクロスプラットフォーム版コマンドラインツールです。Mono を使って Linux、macOS、Windows でエクスポート済みの認証情報を利用できます。Windows GUI は不要です。

通常の TOTP/HOTP に加え、Steam Guard の5文字コード形式にも対応しています。エントリはローカルの XML ボールト(パスワードで暗号化可能)に保存されます。

## クイックスタート

最新リリースをダウンロード:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

各OSでの Mono セットアップは [インストール](installation.md) を、コマンドの全リファレンスは [CLI 使い方](usage.md) をご覧ください。

## このフォークを作った理由

オリジナルの WinAuth は Windows Forms 製の GUI アプリケーションです。このフォークでは認証・TOTP・HOTP・Steam Guard のロジックを `WinAuth.Cli` として切り出し、Mono 対応のコマンドラインツール化しました。これにより、`.maFile`、WinAuth XML エクスポート、あるいは任意の `otpauth://` URI からエクスポートした認証情報を、サーバーやCI、Windows以外のマシン上でヘッドレスに利用できます — ARM64 Linux ワークステーションと macOS の両方で動作確認済みです。

オリジナルの Windows GUI ソースは由来と互換性参照のためリポジトリに残していますが、このフォークで保守対象としているのは `WinAuth.Cli` です。

## 作者

このフォークのメンテナー: Chih-Hsueh "Josh" HUANG([huangjs@gmail.com](mailto:huangjs@gmail.com))
