# コンパイル方法

## Windows GUI(Visual Studio)— オリジナルの WinAuth、由来の記録として保持

### 前提条件

* Visual Studio 2017
* Windows 8.1 SDK

### インストール

1. Visual Studio 2017 をインストールします。インストーラーの「個別のコンポーネント」選択画面で「Windows 8.1 SDK」を必ず有効にしてください。[スクリーンショット](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) を参照。
2. コードベースを git clone するか、ダウンロードして展開します。

### ビルド

1. 開始前に `%AppData%\WinAuth\winauth.xml` をバックアップするか、認証情報をエクスポートしてデータ損失を防いでください。
2. `Net4.5\WinAuth.sln` または `Net3.5\WinAuth-Net3.5.sln` を Visual Studio で開きます。
3. Visual Studio > ビルド > ソリューションのビルド。
4. 成功すると、実行ファイルはソリューションディレクトリ内の `bin\Debug\WinAuth.exe` に生成されます。

## WinAuth.Cli(このフォークの保守対象)

上記と同じ `.sln` 構成に対して、Mono の `xbuild`/`msbuild` で `WinAuth.Cli` プロジェクトをビルドします。公開されている `winauth-cli-mono.zip` リリース成果物を生成する正確な CI ビルド手順は、リポジトリのリリースワークフローを参照してください。
