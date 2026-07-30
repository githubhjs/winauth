# Uso do CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Opções globais:

| Opção | Descrição |
|---|---|
| `--file PATH` | Caminho para o arquivo XML do cofre (padrão `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Senha do cofre, se criptografado. Prefira a variável de ambiente `WINAUTH_PASSWORD` em vez de passar na linha de comando — evita expor a senha na lista de processos. |

## Comandos

| Comando | Descrição |
|---|---|
| `list` | Lista todas as entradas do cofre |
| `code NAME\|ID` | Mostra o código TOTP/HOTP/Steam Guard atual de uma entrada |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Adiciona uma nova entrada manualmente |
| `import --uri otpauth://...` | Importa uma entrada de uma URI `otpauth://` padrão |
| `show NAME\|ID` | Mostra a URI `otpauth://` de uma entrada |
| `rename NAME\|ID NEW_NAME` | Renomeia uma entrada |
| `remove NAME\|ID` | Remove uma entrada |
| `sync NAME\|ID COUNTER` | Define um valor de contador HOTP |
| `export DESTINATION` | Exporta o cofre |
| `passwd --new-password VALUE` | Criptografa, re-chaveia ou descriptografa o cofre |

## Exemplos

```sh
# Importar de uma URI otpauth:// (ex.: de uma exportação de QR code)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Adicionar uma entrada Steam Guard diretamente do segredo Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Obter o código atual
./winauth-cli code steam

# Listar tudo no cofre
./winauth-cli list

# Criptografar o cofre com senha (prefira WINAUTH_PASSWORD a --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Localização do cofre

Por padrão, o cofre é salvo em `~/.config/winauth-cli/winauth.xml`. Mantenha as permissões deste arquivo restritas (`chmod 600`), pois ele contém segredos de autenticador, esteja o cofre criptografado ou não.
