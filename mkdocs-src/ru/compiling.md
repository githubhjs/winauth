# Как собрать

## Windows GUI (Visual Studio) — оригинальный WinAuth, сохранён для истории

### Требования

* Visual Studio 2017
* Windows 8.1 SDK

### Установка

1. Установите Visual Studio 2017. В выборе «Отдельные компоненты» установщика обязательно включите «Windows 8.1 SDK». См. [скриншот](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Склонируйте через git или скачайте и распакуйте исходный код.

### Сборка

1. Перед началом сделайте резервную копию `%AppData%\WinAuth\winauth.xml` или экспортируйте свои аутентификаторы, чтобы избежать потери данных.
2. Откройте файл решения `Net4.5\WinAuth.sln` или `Net3.5\WinAuth-Net3.5.sln` в Visual Studio.
3. Visual Studio > Сборка > Собрать решение.
4. В случае успеха исполняемый файл окажется в `bin\Debug\WinAuth.exe` в каталоге решения.

## WinAuth.Cli (поддерживаемая цель этого форка)

Собирайте через `xbuild`/`msbuild` из Mono для проекта `WinAuth.Cli`, используя ту же структуру `.sln`, что и выше. Точные шаги CI-сборки, используемые для создания опубликованных артефактов `winauth-cli-mono.zip`, см. в release workflow репозитория.
