# winauth-cli

[WinAuth](https://github.com/winauth/winauth) 的跨平台、無 GUI 命令列分支版本,透過 Mono 在 Linux、macOS、Windows 上使用已匯出的驗證器密鑰——不需要 Windows GUI。

支援一般 TOTP/HOTP,以及 Steam Guard 的 5 碼驗證碼格式。所有項目儲存在本機的 XML 保險箱檔案中,可選擇加密。

## 快速開始

下載最新版本:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

各平台的 Mono 安裝方式請見[安裝](installation.md),完整指令參考請見 [CLI 使用說明](usage.md)。

## 為什麼要做這個分支

原始的 WinAuth 是一個 Windows Forms GUI 應用程式。這個分支把驗證器 / TOTP / HOTP / Steam Guard 的邏輯抽出到 `WinAuth.Cli`,做成相容 Mono 的命令列工具,讓匯出的驗證器密鑰(例如來自 `.maFile`、WinAuth XML 匯出檔,或任何 `otpauth://` URI)可以在伺服器、CI、或非 Windows 機器上以無介面(headless)方式使用——已在 ARM64 Linux 工作站與 macOS 上驗證可正常運作。

原始的 Windows GUI 原始碼仍保留在儲存庫中,作為出處與相容性參考,但這個分支實際維護的目標是 `WinAuth.Cli`。

## 作者

此分支由 Chih-Hsueh「Josh」HUANG 維護([huangjs@gmail.com](mailto:huangjs@gmail.com))
