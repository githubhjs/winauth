# استخدام سطر الأوامر

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

الخيارات العامة:

| الخيار | الوصف |
|---|---|
| `--file PATH` | مسار ملف XML الخاص بالخزنة (الافتراضي `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | كلمة مرور الخزنة، إن كانت مشفَّرة. يُفضَّل استخدام متغيّر البيئة `WINAUTH_PASSWORD` بدلاً من تمريرها في سطر الأوامر — لتجنب ظهورها في قائمة العمليات. |

## الأوامر

| الأمر | الوصف |
|---|---|
| `list` | عرض جميع الإدخالات في الخزنة |
| `code NAME\|ID` | عرض رمز TOTP/HOTP/Steam Guard الحالي لإدخال ما |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | إضافة إدخال جديد يدويًا |
| `import --uri otpauth://...` | استيراد إدخال من رابط `otpauth://` قياسي |
| `show NAME\|ID` | عرض رابط `otpauth://` الخاص بإدخال ما |
| `rename NAME\|ID NEW_NAME` | إعادة تسمية إدخال |
| `remove NAME\|ID` | حذف إدخال |
| `sync NAME\|ID COUNTER` | ضبط قيمة عدّاد HOTP |
| `export DESTINATION` | تصدير الخزنة |
| `passwd --new-password VALUE` | تشفير الخزنة، أو إعادة توليد المفتاح، أو فك التشفير |

## أمثلة

```sh
# الاستيراد من رابط otpauth:// (مثلاً من تصدير رمز QR)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# إضافة إدخال Steam Guard مباشرة من سر Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# الحصول على الرمز الحالي
./winauth-cli code steam

# عرض كل ما في الخزنة
./winauth-cli list

# تشفير الخزنة بكلمة مرور (يُفضَّل WINAUTH_PASSWORD بدلاً من --password)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## موقع الخزنة

افتراضيًا، تُحفظ الخزنة في `~/.config/winauth-cli/winauth.xml`. حافظ على صلاحيات هذا الملف صارمة (`chmod 600`)، لأنه يحتوي على أسرار المصادقة، سواء كانت الخزنة نفسها مشفَّرة أم لا.
