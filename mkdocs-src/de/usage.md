# CLI-Nutzung

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Globale Optionen:

| Option | Beschreibung |
|---|---|
| `--file PATH` | Pfad zur Tresor-XML-Datei (Standard: `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Tresor-Passwort, falls verschlüsselt. Bevorzugen Sie die Umgebungsvariable `WINAUTH_PASSWORD` gegenüber der Kommandozeile — so wird das Passwort nicht in der Prozessliste sichtbar. |

## Befehle

| Befehl | Beschreibung |
|---|---|
| `list` | Listet alle Einträge im Tresor auf |
| `code NAME\|ID` | Zeigt den aktuellen TOTP/HOTP/Steam-Guard-Code eines Eintrags |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Fügt manuell einen neuen Eintrag hinzu |
| `import --uri otpauth://...` | Importiert einen Eintrag aus einer Standard-`otpauth://`-URI |
| `show NAME\|ID` | Zeigt die `otpauth://`-URI eines Eintrags |
| `rename NAME\|ID NEW_NAME` | Benennt einen Eintrag um |
| `remove NAME\|ID` | Entfernt einen Eintrag |
| `sync NAME\|ID COUNTER` | Setzt einen HOTP-Zählerwert |
| `export DESTINATION` | Exportiert den Tresor |
| `passwd --new-password VALUE` | Verschlüsselt, erneuert den Schlüssel oder entschlüsselt den Tresor |

## Beispiele

```sh
# Import aus einer otpauth://-URI (z. B. aus einem QR-Code-Export)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Steam-Guard-Eintrag direkt aus dem Base32-Secret hinzufügen
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Aktuellen Code abrufen
./winauth-cli code steam

# Alles im Tresor auflisten
./winauth-cli list

# Tresor mit Passwort verschlüsseln (WINAUTH_PASSWORD statt --password bevorzugen)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Speicherort des Tresors

Standardmäßig wird der Tresor unter `~/.config/winauth-cli/winauth.xml` gespeichert. Halten Sie die Dateiberechtigungen restriktiv (`chmod 600`), da die Datei Authenticator-Secrets enthält — unabhängig davon, ob der Tresor selbst verschlüsselt ist.
