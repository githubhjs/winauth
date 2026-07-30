# winauth-cli

[WinAuth](https://github.com/winauth/winauth) 个指令列版本，係一隻無 GUI、對脈絡（headless）个 ngo-sprod (authenticator) 工具，用 Mono 就做得在 Linux、macOS、Windows 頂高跑。

毋單淨支援普通个 TOTP/HOTP，也支援 Steam Guard 个 5 字元代碼。所有个帳目資料都存在本機个 XML vault 內底，也做得選擇用密碼加密。

## 較遽開始

下載最新个版本：

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

各平台个 Mono 安裝方式请看 [Installation](installation.md)，CLI 个指令詳細用法请看 [CLI Usage](usage.md)。

## 做脈個工具个原因

原本个 WinAuth 係一隻 Windows Forms 个 GUI 應用程式。這隻工具將 authenticator/TOTP/HOTP/Steam Guard 个邏輯抽出來，做低 `WinAuth.Cli`，變成一隻同 Mono 相容个命令列工具。恁樣就做得在 server、CI，抑係毋係 Windows 个機器頂高，無 GUI 就用倒原本 WinAuth 匯出个帳目資料（比方講 `.maFile`、WinAuth XML 匯出檔，抑係 `otpauth://` URI）。已經在 ARM64 Linux workstation 摎 macOS 頂高試過，行得好好。

原本 Windows GUI 个原始碼還係留在 repository 底背做參考，毋過脈隻工具維護个重點係 `WinAuth.Cli`。

## 作者

脈隻工具由 Chih-Hsueh "Josh" HUANG 維護（[huangjs@gmail.com](mailto:huangjs@gmail.com)）。
