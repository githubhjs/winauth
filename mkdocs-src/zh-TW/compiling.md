# 編譯方式

## Windows GUI(Visual Studio)—— 原始 WinAuth,保留作為出處參考

### 先決條件

* Visual Studio 2017
* Windows 8.1 SDK

### 安裝

1. 安裝 Visual Studio 2017。在安裝程式的「個別元件」選擇畫面中,務必勾選啟用「Windows 8.1 SDK」。可參考[這張截圖](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773)。
2. 用 git clone 或直接下載並解壓縮原始碼。

### 建置

1. 開始之前,請先備份 `%AppData%\WinAuth\winauth.xml` 或匯出你的驗證器項目,避免資料遺失。
2. 在 Visual Studio 中開啟 `Net4.5\WinAuth.sln` 或 `Net3.5\WinAuth-Net3.5.sln` 方案檔。
3. Visual Studio > 建置 > 建置方案。
4. 建置成功後,執行檔會出現在方案目錄下的 `bin\Debug\WinAuth.exe`。

## WinAuth.Cli(此分支實際維護的目標)

針對相同的 `.sln` 結構,使用 Mono 的 `xbuild`/`msbuild` 建置 `WinAuth.Cli` 專案。實際用來產生已發布的 `winauth-cli-mono.zip` 發行檔案的確切 CI 建置步驟,請參考儲存庫的發行流程(release workflow)。
