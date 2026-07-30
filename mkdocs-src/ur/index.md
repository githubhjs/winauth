# winauth-cli

[WinAuth](https://github.com/winauth/winauth) کا ایک کراس پلیٹ فارم، بغیر GUI کے فورک، جو Mono کے ذریعے Linux، macOS اور Windows پر ایکسپورٹ شدہ آتھینٹیکیٹر سیکرٹس استعمال کرنے دیتا ہے — Windows GUI کی ضرورت نہیں۔

عام TOTP/HOTP کے ساتھ ساتھ Steam Guard کے 5 حروف والے کوڈ فارمیٹ کو بھی سپورٹ کرتا ہے۔ اندراجات ایک لوکل XML والٹ میں محفوظ ہوتے ہیں، جسے اختیاری طور پر پاس ورڈ سے مرموز کیا جا سکتا ہے۔

## فوری آغاز

تازہ ترین ریلیز ڈاؤن لوڈ کریں:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

ہر پلیٹ فارم پر Mono سیٹ اپ کے لیے [تنصیب](installation.md) دیکھیں، اور مکمل کمانڈ حوالہ کے لیے [CLI استعمال](usage.md) دیکھیں۔

## یہ فورک کیوں بنایا گیا

اصل WinAuth ایک Windows Forms GUI ایپلیکیشن ہے۔ یہ فورک آتھینٹیکیٹر/TOTP/HOTP/Steam Guard منطق کو `WinAuth.Cli` میں الگ کرتا ہے، جو ایک Mono کے ساتھ ہم آہنگ کمانڈ لائن ٹول ہے، تاکہ ایکسپورٹ شدہ آتھینٹیکیٹر سیکرٹس (مثلاً `.maFile`، WinAuth XML ایکسپورٹ، یا کسی بھی `otpauth://` URI سے) سرورز، CI، یا غیر Windows مشینوں پر بغیر انٹرفیس کے استعمال کیے جا سکیں — ARM64 Linux ورک سٹیشن اور macOS دونوں پر کام کرنے کی تصدیق ہو چکی ہے۔

اصل Windows GUI کا سورس کوڈ ذخیرے میں اصلیت اور مطابقت کے حوالے کے طور پر رکھا گیا ہے، لیکن اس فورک کا برقرار رکھا جانے والا ہدف `WinAuth.Cli` ہے۔

## مصنف

یہ فورک Chih-Hsueh "Josh" HUANG کی جانب سے برقرار رکھا جاتا ہے ([huangjs@gmail.com](mailto:huangjs@gmail.com))۔
