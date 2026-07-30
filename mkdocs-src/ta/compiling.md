# எவ்வாறு தொகுப்பது (Compile)

## Windows GUI (Visual Studio) — அசல் WinAuth, தோற்ற குறிப்புக்காக தக்கவைக்கப்பட்டுள்ளது

### முன்நிபந்தனைகள்

* Visual Studio 2017
* Windows 8.1 SDK

### நிறுவல்

1. Visual Studio 2017 ஐ நிறுவவும். நிறுவியின் "Individual components" தேர்வில், "Windows 8.1 SDK" ஐ இயக்கியிருப்பதை உறுதிப்படுத்தவும். [ஸ்கிரீன்ஷாட்](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) ஐப் பார்க்கவும்.
2. git மூலம் குளோன் செய்யவும் அல்லது மூலக் குறியீட்டைப் பதிவிறக்கி பிரித்தெடுக்கவும்.

### உருவாக்கம் (Build)

1. தொடங்குவதற்கு முன், தரவு இழப்பைத் தடுக்க `%AppData%\WinAuth\winauth.xml` ஐ காப்புப் பிரதி எடுக்கவும் அல்லது உங்கள் அங்கீகாரிகளை ஏற்றுமதி செய்யவும்.
2. Visual Studio-இல் `Net4.5\WinAuth.sln` அல்லது `Net3.5\WinAuth-Net3.5.sln` தீர்வுக் கோப்பைத் திறக்கவும்.
3. Visual Studio > Build > Build Solution.
4. வெற்றிகரமாக இருந்தால், செயல்படுத்தக்கூடிய கோப்பு தீர்வு அடைவில் `bin\Debug\WinAuth.exe` இல் இருக்கும்.

## WinAuth.Cli (இந்த fork-இன் பராமரிக்கப்படும் இலக்கு)

மேலே உள்ள அதே `.sln` கட்டமைப்பிற்கு, Mono-இன் `xbuild`/`msbuild` உடன் `WinAuth.Cli` திட்டத்தை உருவாக்கவும். வெளியிடப்பட்ட `winauth-cli-mono.zip` வெளியீட்டுக் கூறுகளை உருவாக்கப் பயன்படுத்தப்படும் சரியான CI உருவாக்க படிகளுக்கு, களஞ்சியத்தின் வெளியீட்டு பணிப்பாய்வை (release workflow) பார்க்கவும்.
