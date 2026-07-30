# طريقة البناء (Compiling)

## واجهة Windows الرسومية (Visual Studio) — WinAuth الأصلي، محفوظ كمرجع للأصل

### المتطلبات الأساسية

* Visual Studio 2017
* Windows 8.1 SDK

### التثبيت

1. ثبّت Visual Studio 2017. في شاشة اختيار "Individual components" بالمثبّت، تأكد من تفعيل "Windows 8.1 SDK". راجع [لقطة الشاشة](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. استنسخ عبر git أو نزّل الشيفرة المصدرية وفكّ ضغطها.

### البناء

1. قبل البدء، احتفظ بنسخة احتياطية من `%AppData%\WinAuth\winauth.xml` أو صدّر أدوات المصادقة لديك لتجنب فقدان البيانات.
2. افتح ملف الحل `Net4.5\WinAuth.sln` أو `Net3.5\WinAuth-Net3.5.sln` في Visual Studio.
3. Visual Studio > Build > Build Solution.
4. عند النجاح، سيكون الملف التنفيذي في `bin\Debug\WinAuth.exe` داخل دليل الحل.

## WinAuth.Cli (الهدف الذي تتم صيانته في هذه النسخة المعدَّلة)

ابنِ باستخدام `xbuild`/`msbuild` من Mono لمشروع `WinAuth.Cli`، باستخدام نفس بنية `.sln` أعلاه. راجع سير عمل الإصدار (release workflow) في المستودع لمعرفة خطوات CI الدقيقة المستخدمة لإنتاج ملفات إصدار `winauth-cli-mono.zip` المنشورة.
