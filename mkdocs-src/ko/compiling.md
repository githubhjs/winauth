# 컴파일 방법

## Windows GUI (Visual Studio) — 출처 참고용으로 유지되는 원본 WinAuth

### 사전 요구사항

* Visual Studio 2017
* Windows 8.1 SDK

### 설치

1. Visual Studio 2017을 설치합니다. 설치 프로그램의 "개별 구성 요소" 선택에서 "Windows 8.1 SDK"를 반드시 활성화하세요. [스크린샷](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) 참고.
2. git clone하거나 코드베이스를 다운로드하여 압축을 풉니다.

### 빌드

1. 시작하기 전에 데이터 손실을 방지하기 위해 `%AppData%\WinAuth\winauth.xml`을 백업하거나 인증기를 내보내세요.
2. Visual Studio에서 `Net4.5\WinAuth.sln` 또는 `Net3.5\WinAuth-Net3.5.sln` 솔루션 파일을 엽니다.
3. Visual Studio > 빌드 > 솔루션 빌드.
4. 성공하면 실행 파일이 솔루션 디렉터리의 `bin\Debug\WinAuth.exe`에 생성됩니다.

## WinAuth.Cli (이 포크에서 실제로 유지 관리되는 대상)

위와 동일한 `.sln` 구조에 대해 Mono의 `xbuild`/`msbuild`로 `WinAuth.Cli` 프로젝트를 빌드합니다. 게시된 `winauth-cli-mono.zip` 릴리스 아티팩트를 생성하는 데 사용된 정확한 CI 빌드 단계는 저장소의 릴리스 워크플로를 참고하세요.
