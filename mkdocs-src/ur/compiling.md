# کمپائل کرنے کا طریقہ

## Windows GUI (Visual Studio) — اصل WinAuth، اصلیت کے حوالے کے طور پر برقرار رکھا گیا

### شرائط

* Visual Studio 2017
* Windows 8.1 SDK

### تنصیب

1. Visual Studio 2017 انسٹال کریں۔ انسٹالر کے "Individual components" انتخاب میں "Windows 8.1 SDK" کو فعال کرنا یقینی بنائیں۔ [اسکرین شاٹ](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) دیکھیں۔
2. git کے ذریعے کلون کریں یا کوڈ بیس ڈاؤن لوڈ کر کے نکالیں۔

### بلڈ کرنا

1. شروع کرنے سے پہلے، ڈیٹا کے نقصان سے بچنے کے لیے `%AppData%\WinAuth\winauth.xml` کا بیک اپ لیں یا اپنے آتھینٹیکیٹرز ایکسپورٹ کریں۔
2. Visual Studio میں `Net4.5\WinAuth.sln` یا `Net3.5\WinAuth-Net3.5.sln` سولوشن فائل کھولیں۔
3. Visual Studio > Build > Build Solution.
4. کامیاب ہونے پر، ایگزیکیوٹیبل فائل سولوشن ڈائریکٹری میں `bin\Debug\WinAuth.exe` پر ہوگی۔

## WinAuth.Cli (اس فورک کا برقرار رکھا جانے والا ہدف)

اوپر جیسی ہی `.sln` ساخت کے لیے، Mono کے `xbuild`/`msbuild` سے `WinAuth.Cli` پراجیکٹ بلڈ کریں۔ شائع شدہ `winauth-cli-mono.zip` ریلیز آرٹیفیکٹس بنانے کے لیے استعمال ہونے والے درست CI بلڈ اقدامات کے لیے ریپوزٹری کا ریلیز ورک فلو دیکھیں۔
