# winauth-cli

[WinAuth](https://github.com/winauth/winauth) चा क्रॉस-प्लॅटफॉर्म, GUI नसलेला फोर्क, जो Mono द्वारे Linux, macOS आणि Windows वर एक्सपोर्ट केलेले ऑथेंटिकेटर सिक्रेट्स वापरण्यास मदत करतो — Windows GUI ची गरज नाही.

सामान्य TOTP/HOTP सोबतच Steam Guard च्या 5-अक्षरी कोड फॉरमॅटलाही सपोर्ट करते. एंट्रीज स्थानिक XML व्हॉल्टमध्ये साठवल्या जातात, ज्या पर्यायाने पासवर्डने एन्क्रिप्ट करता येतात.

## जलद सुरुवात

नवीनतम रिलीज डाउनलोड करा:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

प्रत्येक प्लॅटफॉर्मवर Mono सेटअपसाठी [इन्स्टॉलेशन](installation.md) पहा, आणि संपूर्ण कमांड संदर्भासाठी [CLI वापर](usage.md) पहा.

## हा फोर्क का बनवला

मूळ WinAuth हे Windows Forms GUI अ‍ॅप्लिकेशन आहे. हा फोर्क ऑथेंटिकेटर/TOTP/HOTP/Steam Guard लॉजिकला `WinAuth.Cli` मध्ये वेगळे करतो, जे Mono-सुसंगत कमांड-लाइन टूल आहे, जेणेकरून एक्सपोर्ट केलेले ऑथेंटिकेटर सिक्रेट्स (उदा. `.maFile`, WinAuth XML एक्सपोर्ट, किंवा कोणत्याही `otpauth://` URI मधून) सर्व्हर, CI, किंवा नॉन-Windows मशीनवर हेडलेस पद्धतीने वापरता येतील — ARM64 Linux वर्कस्टेशन आणि macOS या दोन्हींवर काम करत असल्याची पडताळणी केली आहे.

मूळ Windows GUI चा सोर्स कोड मूळ स्रोत आणि सुसंगतता संदर्भासाठी रिपॉझिटरीमध्ये ठेवला आहे, पण या फोर्कचे देखभाल केलेले लक्ष्य `WinAuth.Cli` आहे.

## लेखक

हा फोर्क Chih-Hsueh "Josh" HUANG कडून सांभाळला जातो ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
