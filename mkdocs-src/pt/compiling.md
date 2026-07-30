# Como compilar

## GUI do Windows (Visual Studio) — WinAuth original, mantido por proveniência

### Pré-requisitos

* Visual Studio 2017
* Windows 8.1 SDK

### Instalação

1. Instale o Visual Studio 2017. Na seleção de "Componentes individuais" do instalador, ative "Windows 8.1 SDK". Veja [captura de tela](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Clone com git ou baixe e extraia o código-fonte.

### Build

1. Antes de começar, faça backup de `%AppData%\WinAuth\winauth.xml` ou exporte seus autenticadores para evitar perda de dados.
2. Abra o arquivo de solução `Net4.5\WinAuth.sln` ou `Net3.5\WinAuth-Net3.5.sln` no Visual Studio.
3. Visual Studio > Build > Build Solution.
4. Se bem-sucedido, o executável estará em `bin\Debug\WinAuth.exe` no diretório da solução.

## WinAuth.Cli (alvo mantido deste fork)

Compile com `xbuild`/`msbuild` do Mono sobre o projeto `WinAuth.Cli`, usando a mesma estrutura `.sln` acima. Veja o workflow de release do repositório para os passos exatos de CI usados para gerar os artefatos `winauth-cli-mono.zip` publicados.
