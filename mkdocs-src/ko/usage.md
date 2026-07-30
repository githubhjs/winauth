# CLI 사용법

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

전역 옵션:

| 옵션 | 설명 |
|---|---|
| `--file PATH` | 볼트 XML 파일 경로 (기본값: `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | 볼트가 암호화된 경우의 비밀번호. 명령줄에 직접 전달하기보다는 환경 변수 `WINAUTH_PASSWORD`를 사용하는 것이 좋습니다 — 프로세스 목록에 비밀번호가 노출되는 것을 방지합니다. |

## 명령어

| 명령어 | 설명 |
|---|---|
| `list` | 볼트의 모든 항목 나열 |
| `code NAME\|ID` | 항목의 현재 TOTP/HOTP/Steam Guard 코드 표시 |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | 새 항목을 수동으로 추가 |
| `import --uri otpauth://...` | 표준 `otpauth://` URI에서 항목 가져오기 |
| `show NAME\|ID` | 항목의 `otpauth://` URI 표시 |
| `rename NAME\|ID NEW_NAME` | 항목 이름 변경 |
| `remove NAME\|ID` | 항목 제거 |
| `sync NAME\|ID COUNTER` | HOTP 카운터 값 설정 |
| `export DESTINATION` | 볼트 내보내기 |
| `passwd --new-password VALUE` | 볼트 암호화, 키 재설정, 또는 복호화 |

## 예시

```sh
# otpauth:// URI에서 가져오기 (예: QR 코드 내보내기)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 시크릿으로 Steam Guard 항목 직접 추가
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# 현재 코드 가져오기
./winauth-cli code steam

# 볼트의 모든 항목 나열
./winauth-cli list

# 비밀번호로 볼트 암호화 (--password 대신 WINAUTH_PASSWORD 사용 권장)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## 볼트 위치

기본적으로 볼트는 `~/.config/winauth-cli/winauth.xml`에 저장됩니다. 볼트 자체의 암호화 여부와 관계없이 인증기 시크릿이 포함되어 있으므로 이 파일의 권한을 엄격하게 유지하세요 (`chmod 600`).
