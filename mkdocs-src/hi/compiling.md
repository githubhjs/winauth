# कंपाइल कैसे करें

## Windows GUI (Visual Studio) — मूल WinAuth, स्रोत संदर्भ के लिए रखा गया

### आवश्यकताएँ

* Visual Studio 2017
* Windows 8.1 SDK

### इंस्टॉलेशन

1. Visual Studio 2017 इंस्टॉल करें। इंस्टॉलर के "Individual components" चयन में "Windows 8.1 SDK" ज़रूर एनेबल करें। [स्क्रीनशॉट](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) देखें।
2. Git clone करें या कोडबेस डाउनलोड करके एक्सट्रैक्ट करें।

### बिल्डिंग

1. शुरू करने से पहले, डेटा लॉस से बचने के लिए `%AppData%\WinAuth\winauth.xml` का बैकअप लें या अपने ऑथेंटिकेटर्स एक्सपोर्ट करें।
2. Visual Studio में `Net4.5\WinAuth.sln` या `Net3.5\WinAuth-Net3.5.sln` सॉल्यूशन फ़ाइल खोलें।
3. Visual Studio > Build > Build Solution.
4. सफल होने पर, एक्ज़ीक्यूटेबल सॉल्यूशन डायरेक्ट्री में `bin\Debug\WinAuth.exe` पर मिलेगा।

## WinAuth.Cli (इस फ़ोर्क का मेंटेन किया जाने वाला लक्ष्य)

ऊपर जैसी ही `.sln` संरचना पर, Mono के `xbuild`/`msbuild` से `WinAuth.Cli` प्रोजेक्ट बिल्ड करें। पब्लिश किए गए `winauth-cli-mono.zip` रिलीज़ आर्टिफ़ैक्ट्स बनाने में इस्तेमाल किए गए सटीक CI बिल्ड स्टेप्स के लिए रिपॉज़िटरी का release workflow देखें।
