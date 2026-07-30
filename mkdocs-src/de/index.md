# winauth-cli

Plattformübergreifender, GUI-freier Fork von [WinAuth](https://github.com/winauth/winauth) zur Nutzung exportierter Authenticator-Secrets unter Linux, macOS und Windows via Mono — ohne Windows-GUI.

Unterstützt normales TOTP/HOTP sowie das 5-stellige Steam-Guard-Codeformat. Einträge werden in einem lokalen, optional passwortverschlüsselten XML-Tresor gespeichert.

## Schnellstart

Neueste Version herunterladen:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Siehe [Installation](installation.md) für die Mono-Einrichtung je Plattform und [CLI-Nutzung](usage.md) für die vollständige Befehlsreferenz.

## Warum dieser Fork existiert

Das originale WinAuth ist eine Windows-Forms-GUI-Anwendung. Dieser Fork extrahiert die Authenticator-/TOTP-/HOTP-/Steam-Guard-Logik in `WinAuth.Cli`, ein Mono-kompatibles Kommandozeilentool, damit exportierte Authenticator-Secrets (z. B. aus einer `.maFile`, einem WinAuth-XML-Export oder einer beliebigen `otpauth://`-URI) headless auf Servern, in CI oder auf Nicht-Windows-Maschinen genutzt werden können — nachweislich funktionierend sowohl auf einer ARM64-Linux-Workstation als auch unter macOS.

Der originale Windows-GUI-Quellcode bleibt im Repository als Herkunfts- und Kompatibilitätsreferenz erhalten, das gepflegte Ziel dieses Forks ist jedoch `WinAuth.Cli`.

## Autor

Fork gepflegt von Chih-Hsueh „Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
