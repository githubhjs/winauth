# winauth-cli

Fork multipiattaforma e senza interfaccia grafica di [WinAuth](https://github.com/winauth/winauth) per usare i segreti dell'autenticatore esportati su Linux, macOS e Windows tramite Mono — senza bisogno della GUI di Windows.

Supporta il normale TOTP/HOTP oltre al formato a 5 caratteri di Steam Guard. Le voci sono salvate in un vault XML locale, opzionalmente cifrato con password.

## Avvio rapido

Scarica l'ultima versione:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Vedi [Installazione](installation.md) per la configurazione di Mono su ogni piattaforma, e [Utilizzo del CLI](usage.md) per il riferimento completo dei comandi.

## Perché esiste questo fork

Il WinAuth originale è un'applicazione GUI Windows Forms. Questo fork estrae la logica di autenticatore/TOTP/HOTP/Steam Guard in `WinAuth.Cli`, uno strumento a riga di comando compatibile con Mono, così che i segreti dell'autenticatore esportati (ad esempio da un `.maFile`, un export XML di WinAuth, o qualsiasi URI `otpauth://`) possano essere usati senza interfaccia su server, CI, o macchine non-Windows — verificato funzionante sia su una workstation Linux ARM64 che su macOS.

Il codice sorgente originale della GUI Windows è conservato nel repository come riferimento di provenienza e compatibilità, ma `WinAuth.Cli` è l'obiettivo mantenuto di questo fork.

## Autore

Fork mantenuto da Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
