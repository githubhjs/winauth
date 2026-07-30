# winauth-cli

نسخة معدَّلة (fork) متعددة المنصات وبدون واجهة رسومية من [WinAuth](https://github.com/winauth/winauth) لاستخدام أسرار المصادقة المُصدَّرة على Linux و macOS و Windows عبر Mono — دون الحاجة إلى واجهة Windows الرسومية.

تدعم TOTP/HOTP العادي، بالإضافة إلى تنسيق رمز Steam Guard المكوَّن من 5 أحرف. تُخزَّن الإدخالات في خزنة XML محلية، يمكن تشفيرها اختياريًا بكلمة مرور.

## البدء السريع

نزّل أحدث إصدار:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

راجع [التثبيت](installation.md) لإعداد Mono على كل نظام، و[استخدام سطر الأوامر](usage.md) لمرجع الأوامر الكامل.

## لماذا تم إنشاء هذه النسخة المعدَّلة

WinAuth الأصلي هو تطبيق واجهة رسومية مبني على Windows Forms. تستخرج هذه النسخة منطق المصادقة/TOTP/HOTP/Steam Guard إلى `WinAuth.Cli`، وهي أداة سطر أوامر متوافقة مع Mono، بحيث يمكن استخدام أسرار المصادقة المُصدَّرة (مثلاً من ملف `.maFile`، أو تصدير XML من WinAuth، أو أي رابط `otpauth://`) دون واجهة على الخوادم، أو في CI، أو على أجهزة غير Windows — تم التحقق من عملها على محطة عمل Linux ARM64 وعلى macOS.

يُحتفظ بالشيفرة المصدرية الأصلية لواجهة Windows الرسومية في المستودع كمرجع للأصل والتوافق، لكن الهدف الذي يتم صيانته في هذه النسخة المعدَّلة هو `WinAuth.Cli`.

## المؤلف

هذه النسخة المعدَّلة يصونها Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
