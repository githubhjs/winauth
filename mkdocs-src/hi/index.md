# winauth-cli

[WinAuth](https://github.com/winauth/winauth) का क्रॉस-प्लेटफ़ॉर्म, बिना GUI वाला फ़ोर्क, जो Mono के ज़रिए Linux, macOS और Windows पर एक्सपोर्ट किए गए ऑथेंटिकेटर सीक्रेट्स इस्तेमाल करने देता है — Windows GUI की ज़रूरत नहीं।

सामान्य TOTP/HOTP के साथ-साथ Steam Guard के 5-अक्षर वाले कोड फ़ॉर्मैट को भी सपोर्ट करता है। एंट्रीज़ एक लोकल XML वॉल्ट में सेव होती हैं, जिसे चाहें तो पासवर्ड से एन्क्रिप्ट किया जा सकता है।

## शुरुआत करें

नवीनतम रिलीज़ डाउनलोड करें:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

हर प्लेटफ़ॉर्म पर Mono सेटअप के लिए [इंस्टॉलेशन](installation.md) देखें, और पूरे कमांड रेफ़रेंस के लिए [CLI उपयोग](usage.md) देखें।

## यह फ़ोर्क क्यों बनाया गया

मूल WinAuth एक Windows Forms GUI ऐप्लिकेशन है। यह फ़ोर्क ऑथेंटिकेटर/TOTP/HOTP/Steam Guard लॉजिक को `WinAuth.Cli` में अलग करता है, जो Mono-कम्पैटिबल कमांड-लाइन टूल है, ताकि एक्सपोर्ट किए गए ऑथेंटिकेटर सीक्रेट्स (जैसे `.maFile`, WinAuth XML एक्सपोर्ट, या किसी भी `otpauth://` URI से) सर्वर, CI, या गैर-Windows मशीनों पर बिना GUI के इस्तेमाल किए जा सकें — ARM64 Linux वर्कस्टेशन और macOS दोनों पर काम करना कन्फ़र्म किया गया है।

मूल Windows GUI का सोर्स कोड इस रिपॉज़िटरी में मूल स्रोत और कम्पैटिबिलिटी रेफ़रेंस के लिए रखा गया है, लेकिन इस फ़ोर्क का मेंटेन किया जाने वाला लक्ष्य `WinAuth.Cli` है।

## लेखक

यह फ़ोर्क Chih-Hsueh "Josh" HUANG द्वारा मेंटेन किया जाता है ([huangjs@gmail.com](mailto:huangjs@gmail.com))।
