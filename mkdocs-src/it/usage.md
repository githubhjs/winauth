# Utilizzo del CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Opzioni globali:

| Opzione | Descrizione |
|---|---|
| `--file PATH` | Percorso del file XML del vault (predefinito `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Password del vault, se cifrato. Preferisci la variabile d'ambiente `WINAUTH_PASSWORD` invece di passarla da riga di comando — evita di esporre la password nell'elenco dei processi. |

## Comandi

| Comando | Descrizione |
|---|---|
| `list` | Elenca tutte le voci nel vault |
| `code NAME\|ID` | Mostra il codice TOTP/HOTP/Steam Guard attuale di una voce |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Aggiunge manualmente una nuova voce |
| `import --uri otpauth://...` | Importa una voce da un URI `otpauth://` standard |
| `show NAME\|ID` | Mostra l'URI `otpauth://` di una voce |
| `rename NAME\|ID NEW_NAME` | Rinomina una voce |
| `remove NAME\|ID` | Rimuove una voce |
| `sync NAME\|ID COUNTER` | Imposta un valore di contatore HOTP |
| `export DESTINATION` | Esporta il vault |
| `passwd --new-password VALUE` | Cifra, rigenera la chiave o decifra il vault |

## Esempi

```sh
# Importare da un URI otpauth:// (es. da un export di codice QR)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Aggiungere una voce Steam Guard direttamente dal segreto Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Ottenere il codice attuale
./winauth-cli code steam

# Elencare tutto il contenuto del vault
./winauth-cli list

# Cifrare il vault con una password (preferisci WINAUTH_PASSWORD a --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Posizione del vault

Per impostazione predefinita, il vault è salvato in `~/.config/winauth-cli/winauth.xml`. Mantieni i permessi di questo file restrittivi (`chmod 600`), poiché contiene segreti dell'autenticatore, indipendentemente dal fatto che il vault stesso sia cifrato.
