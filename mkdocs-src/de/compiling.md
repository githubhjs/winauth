# Kompilieren

## Windows-GUI (Visual Studio) — originales WinAuth, als Herkunftsreferenz erhalten

### Voraussetzungen

* Visual Studio 2017
* Windows 8.1 SDK

### Installation

1. Visual Studio 2017 installieren. Stellen Sie in der Komponentenauswahl „Einzelne Komponenten" des Installers sicher, dass „Windows 8.1 SDK" aktiviert ist. Siehe [Screenshot](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Codebasis per Git klonen oder herunterladen und entpacken.

### Build

1. Sichern Sie vor dem Start `%AppData%\WinAuth\winauth.xml` oder exportieren Sie Ihre Authenticatoren, um Datenverlust zu vermeiden.
2. Öffnen Sie die Solution-Datei `Net4.5\WinAuth.sln` oder `Net3.5\WinAuth-Net3.5.sln` in Visual Studio.
3. Visual Studio > Erstellen > Projektmappe erstellen.
4. Bei Erfolg liegt die ausführbare Datei unter `bin\Debug\WinAuth.exe` im Solution-Verzeichnis.

## WinAuth.Cli (gepflegtes Ziel dieses Forks)

Bauen Sie mit Monos `xbuild`/`msbuild` gegen das `WinAuth.Cli`-Projekt, mit derselben `.sln`-Struktur wie oben. Die genauen CI-Build-Schritte zur Erzeugung der veröffentlichten `winauth-cli-mono.zip`-Release-Artefakte finden Sie im Release-Workflow des Repositorys.
