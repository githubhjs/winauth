# ఎలా కంపైల్ చేయాలి

## Windows GUI (Visual Studio) — అసలైన WinAuth, మూల సూచన కోసం ఉంచబడింది

### ముందస్తు అవసరాలు

* Visual Studio 2017
* Windows 8.1 SDK

### ఇన్‌స్టాలేషన్

1. Visual Studio 2017ను ఇన్‌స్టాల్ చేయండి. ఇన్‌స్టాలర్ యొక్క "Individual components" ఎంపికలో "Windows 8.1 SDK"ను తప్పకుండా ప్రారంభించండి. [స్క్రీన్‌షాట్](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) చూడండి.
2. git clone చేయండి లేదా కోడ్‌బేస్‌ను డౌన్‌లోడ్ చేసి ఎక్స్‌ట్రాక్ట్ చేయండి.

### బిల్డ్ చేయడం

1. ప్రారంభించే ముందు, డేటా నష్టాన్ని నివారించడానికి `%AppData%\WinAuth\winauth.xml`ను బ్యాకప్ చేయండి లేదా మీ ఆథెంటికేటర్‌లను ఎగుమతి చేయండి.
2. Visual Studioలో `Net4.5\WinAuth.sln` లేదా `Net3.5\WinAuth-Net3.5.sln` సొల్యూషన్ ఫైల్‌ను తెరవండి.
3. Visual Studio > Build > Build Solution.
4. విజయవంతమైతే, ఎగ్జిక్యూటబుల్ ఫైల్ సొల్యూషన్ డైరెక్టరీలోని `bin\Debug\WinAuth.exe`లో ఉంటుంది.

## WinAuth.Cli (ఈ ఫోర్క్ యొక్క నిర్వహించబడే లక్ష్యం)

పైన ఉన్న అదే `.sln` నిర్మాణం కోసం, Mono యొక్క `xbuild`/`msbuild` తో `WinAuth.Cli` ప్రాజెక్ట్‌ను బిల్డ్ చేయండి. ప్రచురించబడిన `winauth-cli-mono.zip` విడుదల ఆర్టిఫ్యాక్ట్‌లను ఉత్పత్తి చేయడానికి ఉపయోగించే ఖచ్చితమైన CI బిల్డ్ దశల కోసం రిపోజిటరీ యొక్క రిలీజ్ వర్క్‌ఫ్లోను చూడండి.
