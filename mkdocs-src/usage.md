# CLI Usage

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Global options:

| Option | Description |
|---|---|
| `--file PATH` | Path to the vault XML file (defaults to `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Vault password, if encrypted. Prefer the `WINAUTH_PASSWORD` environment variable over passing this on the command line — it avoids exposing the password in the process list. |

## Commands

| Command | Description |
|---|---|
| `list` | List all entries in the vault |
| `code NAME\|ID` | Print the current TOTP/HOTP/Steam Guard code for an entry |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Add a new entry manually |
| `import --uri otpauth://...` | Import an entry from a standard `otpauth://` URI |
| `show NAME\|ID` | Print an entry's `otpauth://` URI |
| `rename NAME\|ID NEW_NAME` | Rename an entry |
| `remove NAME\|ID` | Remove an entry |
| `sync NAME\|ID COUNTER` | Set an HOTP counter value |
| `export DESTINATION` | Export the vault |
| `passwd --new-password VALUE` | Encrypt, re-key, or decrypt the vault |

## Examples

```sh
# Import from an otpauth:// URI (e.g. from a QR code export)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Add a Steam Guard entry directly from its Base32 secret
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Get the current code
./winauth-cli code steam

# List everything in the vault
./winauth-cli list

# Encrypt the vault with a password (use WINAUTH_PASSWORD instead of --password where possible)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Vault location

By default, the vault is stored at `~/.config/winauth-cli/winauth.xml`. Keep this file's permissions restrictive (`chmod 600`) since it contains authenticator secrets, whether or not the vault itself is password-encrypted.
