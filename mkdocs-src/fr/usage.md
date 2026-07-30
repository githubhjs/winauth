# Utilisation du CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Options globales :

| Option | Description |
|---|---|
| `--file PATH` | Chemin du fichier XML du coffre (par défaut `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Mot de passe du coffre, s'il est chiffré. Préférez la variable d'environnement `WINAUTH_PASSWORD` plutôt que de le passer en ligne de commande — cela évite d'exposer le mot de passe dans la liste des processus. |

## Commandes

| Commande | Description |
|---|---|
| `list` | Liste toutes les entrées du coffre |
| `code NAME\|ID` | Affiche le code TOTP/HOTP/Steam Guard actuel d'une entrée |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Ajoute manuellement une nouvelle entrée |
| `import --uri otpauth://...` | Importe une entrée depuis une URI `otpauth://` standard |
| `show NAME\|ID` | Affiche l'URI `otpauth://` d'une entrée |
| `rename NAME\|ID NEW_NAME` | Renomme une entrée |
| `remove NAME\|ID` | Supprime une entrée |
| `sync NAME\|ID COUNTER` | Définit une valeur de compteur HOTP |
| `export DESTINATION` | Exporte le coffre |
| `passwd --new-password VALUE` | Chiffre, rechiffre ou déchiffre le coffre |

## Exemples

```sh
# Importer depuis une URI otpauth:// (par ex. depuis un export de QR code)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Ajouter une entrée Steam Guard directement depuis son secret Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Obtenir le code actuel
./winauth-cli code steam

# Lister le contenu du coffre
./winauth-cli list

# Chiffrer le coffre avec un mot de passe (préférez WINAUTH_PASSWORD à --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Emplacement du coffre

Par défaut, le coffre est stocké dans `~/.config/winauth-cli/winauth.xml`. Gardez les permissions de ce fichier restrictives (`chmod 600`), car il contient des secrets d'authentificateur, que le coffre soit chiffré ou non.
