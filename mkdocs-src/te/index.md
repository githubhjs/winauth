# winauth-cli

[WinAuth](https://github.com/winauth/winauth) యొక్క క్రాస్-ప్లాట్‌ఫారమ్, GUI లేని ఫోర్క్, ఇది Mono ద్వారా Linux, macOS మరియు Windows పై ఎగుమతి చేసిన ఆథెంటికేటర్ సీక్రెట్‌లను ఉపయోగించడానికి వీలు కల్పిస్తుంది — Windows GUI అవసరం లేదు.

సాధారణ TOTP/HOTP తో పాటు Steam Guard యొక్క 5-అక్షరాల కోడ్ ఫార్మాట్‌ను కూడా సపోర్ట్ చేస్తుంది. ఎంట్రీలు స్థానిక XML వాల్ట్‌లో నిల్వ చేయబడతాయి, దీన్ని ఐచ్ఛికంగా పాస్‌వర్డ్‌తో ఎన్‌క్రిప్ట్ చేయవచ్చు.

## త్వరిత ప్రారంభం

తాజా విడుదలను డౌన్‌లోడ్ చేయండి:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

ప్రతి ప్లాట్‌ఫారమ్‌లో Mono సెటప్ కోసం [ఇన్‌స్టాలేషన్](installation.md) చూడండి, పూర్తి కమాండ్ రిఫరెన్స్ కోసం [CLI వినియోగం](usage.md) చూడండి.

## ఈ ఫోర్క్ ఎందుకు ఉంది

అసలైన WinAuth ఒక Windows Forms GUI అప్లికేషన్. ఈ ఫోర్క్ ఆథెంటికేటర్/TOTP/HOTP/Steam Guard లాజిక్‌ను `WinAuth.Cli`లోకి వేరు చేస్తుంది, ఇది Mono-అనుకూల కమాండ్-లైన్ సాధనం, తద్వారా ఎగుమతి చేసిన ఆథెంటికేటర్ సీక్రెట్‌లను (ఉదా. `.maFile` నుండి, WinAuth XML ఎగుమతి నుండి, లేదా ఏదైనా `otpauth://` URI నుండి) సర్వర్‌లు, CI, లేదా Windows కాని మెషీన్‌లలో హెడ్‌లెస్‌గా ఉపయోగించవచ్చు — ARM64 Linux వర్క్‌స్టేషన్ మరియు macOS రెండింటిలోనూ పనిచేస్తుందని ధృవీకరించబడింది.

అసలైన Windows GUI సోర్స్ కోడ్ మూలం మరియు అనుకూలత సూచన కోసం రిపోజిటరీలో ఉంచబడింది, కానీ ఈ ఫోర్క్ యొక్క నిర్వహించబడే లక్ష్యం `WinAuth.Cli`.

## రచయిత

ఈ ఫోర్క్‌ను Chih-Hsueh "Josh" HUANG నిర్వహిస్తారు ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
