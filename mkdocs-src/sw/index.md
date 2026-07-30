# winauth-cli

Tawi (fork) ya jukwaa mbalimbali, isiyo na GUI ya [WinAuth](https://github.com/winauth/winauth) kwa ajili ya kutumia siri za uthibitishaji zilizohamishwa (exported) kwenye Linux, macOS, na Windows kupitia Mono — bila kuhitaji GUI ya Windows.

Inasaidia TOTP/HOTP ya kawaida, pamoja na muundo wa msimbo wa herufi 5 wa Steam Guard. Maingizo huhifadhiwa kwenye hifadhi (vault) ya XML ya ndani, ambayo inaweza kusimbwa kwa nywila kwa hiari.

## Anza haraka

Pakua toleo jipya zaidi:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Angalia [Usakinishaji](installation.md) kwa mipangilio ya Mono kwa kila jukwaa, na [Matumizi ya CLI](usage.md) kwa marejeo kamili ya amri.

## Kwa nini tawi hili lipo

WinAuth asili ni programu ya GUI ya Windows Forms. Tawi hili huchota mantiki ya uthibitishaji/TOTP/HOTP/Steam Guard katika `WinAuth.Cli`, chombo cha mstari wa amri kinachooana na Mono, ili siri za uthibitishaji zilizohamishwa (mfano kutoka `.maFile`, uhamishaji wa XML wa WinAuth, au URI yoyote ya `otpauth://`) ziweze kutumika bila kiolesura kwenye seva, CI, au mashine zisizo za Windows — imethibitishwa kufanya kazi kwenye kituo cha kazi cha Linux ARM64 na macOS.

Msimbo chanzi asili wa GUI ya Windows umehifadhiwa kwenye hazina kama rejeleo la asili na uoanifu, lakini lengo linalodumishwa la tawi hili ni `WinAuth.Cli`.

## Mwandishi

Tawi hili linadumishwa na Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
