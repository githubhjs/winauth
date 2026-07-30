# winauth-cli

[WinAuth](https://github.com/winauth/winauth) 的跨平台、无 GUI 命令行分支版本,通过 Mono 在 Linux、macOS、Windows 上使用已导出的验证器密钥——不需要 Windows 图形界面。

支持普通 TOTP/HOTP,以及 Steam Guard 的 5 位验证码格式。所有条目保存在本地的 XML 保险库文件中,可选择加密。

## 快速开始

下载最新版本:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

各平台的 Mono 安装方式见[安装](installation.md),完整命令参考见 [CLI 使用说明](usage.md)。

## 为什么要做这个分支

原始的 WinAuth 是一个 Windows Forms 图形界面应用程序。这个分支把验证器 / TOTP / HOTP / Steam Guard 的逻辑抽取到 `WinAuth.Cli`,做成兼容 Mono 的命令行工具,让导出的验证器密钥(例如来自 `.maFile`、WinAuth XML 导出文件,或任意 `otpauth://` URI)可以在服务器、CI、或非 Windows 机器上以无界面(headless)方式使用——已在 ARM64 Linux 工作站与 macOS 上验证可正常运行。

原始的 Windows 图形界面源代码仍保留在仓库中,作为溯源与兼容性参考,但这个分支实际维护的目标是 `WinAuth.Cli`。

## 作者

此分支由 Chih-Hsueh「Josh」HUANG 维护([huangjs@gmail.com](mailto:huangjs@gmail.com))
