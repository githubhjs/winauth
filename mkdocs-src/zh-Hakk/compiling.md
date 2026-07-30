# Compile 个方法

## Windows GUI（Visual Studio）— 原本个 WinAuth，留在 repo 底背做參考

### 事先愛有

* Visual Studio 2017
* Windows 8.1 SDK

### 安裝

1. 安裝 Visual Studio 2017。安裝个時節，在「Individual components」揀選愛揀得倒「Windows 8.1 SDK」。请看[這隻連結](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773)。
2. git clone 抑係下載 code 了解壓縮。

### Build

1. Build 之前，先備份 `%AppData%\WinAuth\winauth.xml`，抑係先匯出你个 authenticator 資料，恁樣正毋會遺失資料。
2. 用 Visual Studio 打開 `Net4.5\WinAuth.sln` 抑係 `Net3.5\WinAuth-Net3.5.sln` solution 檔。
3. Visual Studio > Build > Build Solution。
4. Build 好个話，執行檔就在 solution 目錄底背个 `bin\Debug\WinAuth.exe`。

## WinAuth.Cli（脈隻工具維護个重點）

同一隻 `.sln` solution，用 Mono 个 `xbuild`/`msbuild` 就做得 build `WinAuth.Cli` project。發布个 `winauth-cli-mono.zip` 版本 artifact 係 CI build 流程做出來个，詳細請看 repository 个 release workflow。
