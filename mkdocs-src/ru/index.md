# winauth-cli

Кроссплатформенный форк [WinAuth](https://github.com/winauth/winauth) без графического интерфейса для использования экспортированных секретов аутентификатора в Linux, macOS и Windows через Mono — без необходимости в GUI Windows.

Поддерживает обычный TOTP/HOTP, а также 5-символьный формат кода Steam Guard. Записи хранятся в локальном XML-хранилище, опционально зашифрованном паролем.

## Быстрый старт

Скачайте последнюю версию:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

См. [Установку](installation.md) для настройки Mono на разных платформах и [Использование CLI](usage.md) для полного справочника команд.

## Зачем нужен этот форк

Оригинальный WinAuth — это GUI-приложение на Windows Forms. Этот форк выделяет логику аутентификатора/TOTP/HOTP/Steam Guard в `WinAuth.Cli` — инструмент командной строки, совместимый с Mono, чтобы экспортированные секреты аутентификатора (например, из `.maFile`, XML-экспорта WinAuth или любого URI `otpauth://`) можно было использовать без интерфейса на серверах, в CI или на не-Windows машинах — проверено на рабочей станции ARM64 Linux и на macOS.

Исходный код GUI для Windows сохранён в репозитории для истории и совместимости, но поддерживаемая цель этого форка — `WinAuth.Cli`.

## Автор

Форк поддерживает Chih-Hsueh «Josh» HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
