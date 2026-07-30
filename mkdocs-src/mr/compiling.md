# कसे कंपाइल करावे

## Windows GUI (Visual Studio) — मूळ WinAuth, मूळ स्रोत संदर्भासाठी ठेवले आहे

### पूर्वअटी

* Visual Studio 2017
* Windows 8.1 SDK

### इन्स्टॉलेशन

1. Visual Studio 2017 इन्स्टॉल करा. इन्स्टॉलरच्या "Individual components" निवडीत "Windows 8.1 SDK" सक्रिय करणे सुनिश्चित करा. [स्क्रीनशॉट](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) पहा.
2. git clone करा किंवा कोडबेस डाउनलोड करून एक्स्ट्रॅक्ट करा.

### बिल्ड करणे

1. सुरू करण्यापूर्वी, डेटा गमावणे टाळण्यासाठी `%AppData%\WinAuth\winauth.xml` चा बॅकअप घ्या किंवा तुमचे ऑथेंटिकेटर्स एक्सपोर्ट करा.
2. Visual Studio मध्ये `Net4.5\WinAuth.sln` किंवा `Net3.5\WinAuth-Net3.5.sln` सोल्यूशन फाइल उघडा.
3. Visual Studio > Build > Build Solution.
4. यशस्वी झाल्यास, एक्झिक्युटेबल फाइल सोल्यूशन डिरेक्टरीतील `bin\Debug\WinAuth.exe` येथे असेल.

## WinAuth.Cli (या फोर्कचे देखभाल केलेले लक्ष्य)

वरील प्रमाणेच `.sln` रचनेसाठी, Mono च्या `xbuild`/`msbuild` ने `WinAuth.Cli` प्रोजेक्ट बिल्ड करा. प्रकाशित `winauth-cli-mono.zip` रिलीज आर्टिफॅक्ट्स तयार करण्यासाठी वापरलेल्या नेमक्या CI बिल्ड पायऱ्यांसाठी रिपॉझिटरीचा रिलीज वर्कफ्लो पहा.
