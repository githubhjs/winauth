# Jinsi ya Kujenga (Compile)

## GUI ya Windows (Visual Studio) — WinAuth asili, imehifadhiwa kama rejeleo la asili

### Mahitaji ya awali

* Visual Studio 2017
* Windows 8.1 SDK

### Usakinishaji

1. Sakinisha Visual Studio 2017. Katika uchaguzi wa "Individual components" wa kisakinishi, hakikisha umewezesha "Windows 8.1 SDK". Angalia [picha ya skrini](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Fanya git clone au pakua na ufungue msimbo chanzi.

### Kujenga

1. Kabla ya kuanza, hakikisha umehifadhi nakala ya `%AppData%\WinAuth\winauth.xml` au hamisha (export) vithibitishaji vyako ili kuepuka kupoteza data.
2. Fungua faili la suluhisho `Net4.5\WinAuth.sln` au `Net3.5\WinAuth-Net3.5.sln` kwenye Visual Studio.
3. Visual Studio > Build > Build Solution.
4. Ikifanikiwa, faili la utekelezaji litakuwa katika `bin\Debug\WinAuth.exe` ndani ya saraka ya suluhisho.

## WinAuth.Cli (lengo linalodumishwa la tawi hili)

Jenga kwa kutumia `xbuild`/`msbuild` ya Mono kwa mradi wa `WinAuth.Cli`, ukitumia muundo uleule wa `.sln` kama hapo juu. Angalia mtiririko wa kazi wa utoaji (release workflow) wa hazina kwa hatua sahihi za ujenzi wa CI zinazotumika kuzalisha vipengele vilivyochapishwa vya `winauth-cli-mono.zip`.
