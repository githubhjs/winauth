# 编译方式

## Windows 图形界面(Visual Studio)—— 原始 WinAuth,保留作为溯源参考

### 前置条件

* Visual Studio 2017
* Windows 8.1 SDK

### 安装

1. 安装 Visual Studio 2017。在安装程序的"单个组件"选择界面中,务必勾选启用"Windows 8.1 SDK"。可参考[此截图](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773)。
2. 通过 git clone 或直接下载并解压源代码。

### 构建

1. 开始前请先备份 `%AppData%\WinAuth\winauth.xml` 或导出验证器条目,以避免数据丢失。
2. 在 Visual Studio 中打开 `Net4.5\WinAuth.sln` 或 `Net3.5\WinAuth-Net3.5.sln` 解决方案文件。
3. Visual Studio > 生成 > 生成解决方案。
4. 构建成功后,可执行文件会出现在解决方案目录下的 `bin\Debug\WinAuth.exe`。

## WinAuth.Cli(此分支实际维护的目标)

针对相同的 `.sln` 结构,使用 Mono 的 `xbuild`/`msbuild` 构建 `WinAuth.Cli` 项目。用于生成已发布的 `winauth-cli-mono.zip` 发行文件的确切 CI 构建步骤,请参考仓库的发布工作流(release workflow)。
