# Cómo compilar

## GUI de Windows (Visual Studio) — WinAuth original, conservado por procedencia

### Requisitos previos

* Visual Studio 2017
* Windows 8.1 SDK

### Instalación

1. Instala Visual Studio 2017. En la selección de "Componentes individuales" del instalador, asegúrate de activar "Windows 8.1 SDK". Ver [captura de pantalla](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Clona con git o descarga y extrae el código base.

### Compilación

1. Antes de empezar, haz una copia de seguridad de `%AppData%\WinAuth\winauth.xml` o exporta tus autenticadores para evitar la pérdida de datos.
2. Abre el archivo de solución `Net4.5\WinAuth.sln` o `Net3.5\WinAuth-Net3.5.sln` en Visual Studio.
3. Visual Studio > Compilar > Compilar solución.
4. Si tiene éxito, el ejecutable estará en `bin\Debug\WinAuth.exe` dentro del directorio de la solución.

## WinAuth.Cli (objetivo mantenido de esta bifurcación)

Compila con `xbuild`/`msbuild` de Mono sobre el proyecto `WinAuth.Cli`, usando la misma estructura `.sln` de arriba. Consulta el flujo de trabajo de publicación (release workflow) del repositorio para los pasos exactos de CI usados para generar los artefactos publicados `winauth-cli-mono.zip`.
