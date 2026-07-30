# ji-ltar compile byed

## Windows GUI (Visual Studio) — WinAuth ngo-ma, 'byung-khungs dpe-mtshon che dur nyar-yod

### sngon-'gro'i 'phrod-rkyen

* Visual Studio 2017
* Windows 8.1 SDK

### sgrig-sbyor

1. Visual Studio 2017 sgrig-sbyor byos. sgrig-sbyor byed-cha'i "Individual components" gdam-kha nang "Windows 8.1 SDK" gsal-'don byed thub-pa nges-par byos. [par-'dzin](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) la ltos.
2. git clone byos yang-na code-gzhi phab-len byas la phye-bshig byos.

### 'grub-'don (Build)

1. 'go-tsugs snga-rol `%AppData%\WinAuth\winauth.xml` nyar-tshab byos yang-na khyed-kyi authenticator rnams phyir-'don byos, gnas-tshul brlag-pa'i nyen-kha 'gog phyir.
2. Visual Studio nang `Net4.5\WinAuth.sln` yang-na `Net3.5\WinAuth-Net3.5.sln` solution yig-cha phye.
3. Visual Studio > Build > Build Solution.
4. 'grub-grangs yin na, lag-len yig-cha ni solution sde-tshan nang `bin\Debug\WinAuth.exe` thog yod par 'gyur.

## WinAuth.Cli (shag 'di'i maintain byed-pa'i dmigs-yul)

gong gi `.sln` sdebs-tshan gcig-mtshungs la Mono'i `xbuild`/`msbuild` thog `WinAuth.Cli` project 'grub-'don byos. spel-ba'i `winauth-cli-mono.zip` thon-rigs artifact bzo-thabs kyi CI build gom-pa nges-can chad la mdzod-khang gi release workflow la ltos.
