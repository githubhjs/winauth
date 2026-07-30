# winauth-cli

[WinAuth](https://github.com/winauth/winauth)를 GUI 없이 크로스플랫폼으로 포크한 버전입니다. Mono를 통해 Linux, macOS, Windows에서 내보낸 인증기 시크릿을 사용할 수 있으며, Windows GUI가 필요하지 않습니다.

일반 TOTP/HOTP는 물론 Steam Guard의 5자리 코드 형식도 지원합니다. 항목은 로컬 XML 보관함(볼트)에 저장되며, 선택적으로 비밀번호로 암호화할 수 있습니다.

## 빠른 시작

최신 릴리스 다운로드:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

플랫폼별 Mono 설치 방법은 [설치](installation.md)를, 전체 명령어 참조는 [CLI 사용법](usage.md)을 참고하세요.

## 이 포크를 만든 이유

원본 WinAuth는 Windows Forms GUI 애플리케이션입니다. 이 포크는 인증기/TOTP/HOTP/Steam Guard 로직을 `WinAuth.Cli`로 분리하여 Mono와 호환되는 커맨드라인 도구로 만들었습니다. 이를 통해 내보낸 인증기 시크릿(예: `.maFile`, WinAuth XML 내보내기, 또는 임의의 `otpauth://` URI)을 서버, CI, 또는 Windows가 아닌 머신에서 헤드리스로 사용할 수 있습니다 — ARM64 Linux 워크스테이션과 macOS 모두에서 동작 확인됨.

원본 Windows GUI 소스 코드는 출처와 호환성 참조를 위해 저장소에 남아 있지만, 이 포크에서 실제로 유지 관리되는 대상은 `WinAuth.Cli`입니다.

## 작성자

이 포크는 Chih-Hsueh "Josh" HUANG이 관리합니다 ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
