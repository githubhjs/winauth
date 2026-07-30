# Come compilare

## GUI Windows (Visual Studio) — WinAuth originale, conservato per provenienza

### Prerequisiti

* Visual Studio 2017
* Windows 8.1 SDK

### Installazione

1. Installa Visual Studio 2017. Nella selezione "Singoli componenti" dell'installer, assicurati di abilitare "Windows 8.1 SDK". Vedi [screenshot](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Clona con git o scarica ed estrai il codice sorgente.

### Compilazione

1. Prima di iniziare, fai un backup di `%AppData%\WinAuth\winauth.xml` o esporta i tuoi autenticatori per evitare perdite di dati.
2. Apri il file di soluzione `Net4.5\WinAuth.sln` o `Net3.5\WinAuth-Net3.5.sln` in Visual Studio.
3. Visual Studio > Genera > Genera soluzione.
4. Se riuscito, l'eseguibile si troverà in `bin\Debug\WinAuth.exe` nella directory della soluzione.

## WinAuth.Cli (obiettivo mantenuto di questo fork)

Compila con `xbuild`/`msbuild` di Mono sul progetto `WinAuth.Cli`, usando la stessa struttura `.sln` sopra indicata. Consulta il workflow di release del repository per i passaggi CI esatti usati per generare gli artefatti `winauth-cli-mono.zip` pubblicati.
