# winauth-cli

[WinAuth](https://github.com/winauth/winauth) இன் தளங்களிடையேயான, GUI இல்லாத fork ஆகும், இது Mono வழியாக Linux, macOS மற்றும் Windows-இல் ஏற்றுமதி செய்யப்பட்ட அங்கீகார ரகசியங்களை (authenticator secrets) பயன்படுத்த அனுமதிக்கிறது — Windows GUI தேவையில்லை.

வழக்கமான TOTP/HOTP-உடன், Steam Guard-இன் 5-எழுத்து குறியீட்டு வடிவமைப்பையும் ஆதரிக்கிறது. உள்ளீடுகள் ஒரு உள்ளூர் XML பெட்டகத்தில் (vault) சேமிக்கப்படுகின்றன, விருப்பப்படி கடவுச்சொல்லால் குறியாக்கம் செய்யலாம்.

## விரைவு தொடக்கம்

சமீபத்திய வெளியீட்டை பதிவிறக்கவும்:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

ஒவ்வொரு தளத்திலும் Mono அமைப்புக்கு [நிறுவல்](installation.md) பார்க்கவும், முழு கட்டளை குறிப்புக்கு [CLI பயன்பாடு](usage.md) பார்க்கவும்.

## இந்த fork ஏன் உருவாக்கப்பட்டது

அசல் WinAuth ஒரு Windows Forms GUI பயன்பாடு ஆகும். இந்த fork அங்கீகார/TOTP/HOTP/Steam Guard தர்க்கத்தை `WinAuth.Cli` எனும் Mono-இணக்கமான கட்டளை-வரி கருவியாக பிரித்தெடுக்கிறது, இதனால் ஏற்றுமதி செய்யப்பட்ட அங்கீகார ரகசியங்களை (எ.கா. `.maFile`, WinAuth XML ஏற்றுமதி, அல்லது எந்த `otpauth://` URI-இலிருந்தும்) சேவையகங்களில், CI-இல், அல்லது Windows அல்லாத கணினிகளில் தலைமையின்றி (headless) பயன்படுத்தலாம் — ARM64 Linux பணிநிலையம் மற்றும் macOS இரண்டிலும் இயங்குவது உறுதி செய்யப்பட்டுள்ளது.

அசல் Windows GUI மூலக் குறியீடு தோற்றம் மற்றும் இணக்கத் தன்மைக்கான குறிப்பாக களஞ்சியத்தில் (repository) தக்கவைக்கப்பட்டுள்ளது, ஆனால் இந்த fork-இன் பராமரிக்கப்படும் இலக்கு `WinAuth.Cli` ஆகும்.

## ஆசிரியர்

இந்த fork ஐ Chih-Hsueh "Josh" HUANG பராமரிக்கிறார் ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
