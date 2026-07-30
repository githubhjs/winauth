# Uso del CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Opciones globales:

| Opción | Descripción |
|---|---|
| `--file PATH` | Ruta al archivo XML de la bóveda (por defecto `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Contraseña de la bóveda, si está cifrada. Es preferible usar la variable de entorno `WINAUTH_PASSWORD` en lugar de pasarla en la línea de comandos — evita exponer la contraseña en la lista de procesos. |

## Comandos

| Comando | Descripción |
|---|---|
| `list` | Lista todas las entradas de la bóveda |
| `code NAME\|ID` | Muestra el código TOTP/HOTP/Steam Guard actual de una entrada |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Añade una nueva entrada manualmente |
| `import --uri otpauth://...` | Importa una entrada desde una URI `otpauth://` estándar |
| `show NAME\|ID` | Muestra la URI `otpauth://` de una entrada |
| `rename NAME\|ID NEW_NAME` | Renombra una entrada |
| `remove NAME\|ID` | Elimina una entrada |
| `sync NAME\|ID COUNTER` | Establece un valor de contador HOTP |
| `export DESTINATION` | Exporta la bóveda |
| `passwd --new-password VALUE` | Cifra, re-cifra o descifra la bóveda |

## Ejemplos

```sh
# Importar desde una URI otpauth:// (p. ej. desde un código QR exportado)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Añadir una entrada de Steam Guard directamente desde su secreto Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Obtener el código actual
./winauth-cli code steam

# Listar todo lo que hay en la bóveda
./winauth-cli list

# Cifrar la bóveda con una contraseña (usa WINAUTH_PASSWORD en vez de --password cuando sea posible)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Ubicación de la bóveda

Por defecto, la bóveda se guarda en `~/.config/winauth-cli/winauth.xml`. Mantén los permisos de este archivo restringidos (`chmod 600`), ya que contiene secretos de autenticador, esté o no cifrada la bóveda.
