# winauth-cli

Bifurcación (fork) multiplataforma y sin interfaz gráfica de [WinAuth](https://github.com/winauth/winauth) para usar secretos de autenticador exportados en Linux, macOS y Windows a través de Mono, sin necesidad de la GUI de Windows.

Soporta TOTP/HOTP normal, además del formato de código de 5 caracteres de Steam Guard. Las entradas se almacenan en una bóveda XML local, opcionalmente cifrada con contraseña.

## Inicio rápido

Descarga la última versión:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Consulta [Instalación](installation.md) para la configuración de Mono en cada plataforma, y [Uso del CLI](usage.md) para la referencia completa de comandos.

## Por qué existe esta bifurcación

El WinAuth original es una aplicación GUI de Windows Forms. Esta bifurcación extrae la lógica de autenticador/TOTP/HOTP/Steam Guard en `WinAuth.Cli`, una herramienta de línea de comandos compatible con Mono, para que los secretos de autenticador exportados (por ejemplo, de un `.maFile`, una exportación XML de WinAuth, o cualquier URI `otpauth://`) puedan usarse sin interfaz gráfica en servidores, CI, o máquinas que no son Windows — verificado funcionando tanto en una estación de trabajo Linux ARM64 como en macOS.

El código fuente original de la GUI de Windows se conserva en el repositorio como referencia de procedencia y compatibilidad, pero `WinAuth.Cli` es el objetivo mantenido de esta bifurcación.

## Autor

Bifurcación mantenida por Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
