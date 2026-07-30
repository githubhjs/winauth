# Использование CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Глобальные опции:

| Опция | Описание |
|---|---|
| `--file PATH` | Путь к XML-файлу хранилища (по умолчанию `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Пароль хранилища, если оно зашифровано. Предпочтительнее использовать переменную окружения `WINAUTH_PASSWORD`, а не передавать пароль в командной строке — это исключает его появление в списке процессов. |

## Команды

| Команда | Описание |
|---|---|
| `list` | Вывести список всех записей в хранилище |
| `code NAME\|ID` | Показать текущий TOTP/HOTP/Steam Guard код записи |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Добавить новую запись вручную |
| `import --uri otpauth://...` | Импортировать запись из стандартного URI `otpauth://` |
| `show NAME\|ID` | Показать URI `otpauth://` записи |
| `rename NAME\|ID NEW_NAME` | Переименовать запись |
| `remove NAME\|ID` | Удалить запись |
| `sync NAME\|ID COUNTER` | Установить значение счётчика HOTP |
| `export DESTINATION` | Экспортировать хранилище |
| `passwd --new-password VALUE` | Зашифровать, сменить ключ или расшифровать хранилище |

## Примеры

```sh
# Импорт из URI otpauth:// (например, из экспорта QR-кода)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Добавить запись Steam Guard напрямую из секрета Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Получить текущий код
./winauth-cli code steam

# Вывести список всего в хранилище
./winauth-cli list

# Зашифровать хранилище паролем (предпочтительнее WINAUTH_PASSWORD, а не --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Расположение хранилища

По умолчанию хранилище сохраняется в `~/.config/winauth-cli/winauth.xml`. Держите права доступа к этому файлу строгими (`chmod 600`), так как он содержит секреты аутентификатора независимо от того, зашифровано ли само хранилище.
