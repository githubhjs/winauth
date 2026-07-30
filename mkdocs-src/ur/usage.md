# CLI کا استعمال

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

عمومی اختیارات:

| اختیار | تفصیل |
|---|---|
| `--file PATH` | والٹ XML فائل کا راستہ (ڈیفالٹ `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | والٹ کا پاس ورڈ، اگر مرموز ہو۔ کمانڈ لائن پر دینے کے بجائے ماحولیاتی متغیر `WINAUTH_PASSWORD` استعمال کرنا بہتر ہے — اس سے پاس ورڈ پروسیس لسٹ میں ظاہر نہیں ہوتا۔ |

## کمانڈز

| کمانڈ | تفصیل |
|---|---|
| `list` | والٹ کے تمام اندراجات کی فہرست دکھاتا ہے |
| `code NAME\|ID` | کسی اندراج کا موجودہ TOTP/HOTP/Steam Guard کوڈ دکھاتا ہے |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | دستی طور پر نیا اندراج شامل کرتا ہے |
| `import --uri otpauth://...` | معیاری `otpauth://` URI سے اندراج درآمد کرتا ہے |
| `show NAME\|ID` | کسی اندراج کا `otpauth://` URI دکھاتا ہے |
| `rename NAME\|ID NEW_NAME` | کسی اندراج کا نام تبدیل کرتا ہے |
| `remove NAME\|ID` | کسی اندراج کو ہٹاتا ہے |
| `sync NAME\|ID COUNTER` | HOTP کاؤنٹر ویلیو سیٹ کرتا ہے |
| `export DESTINATION` | والٹ برآمد کرتا ہے |
| `passwd --new-password VALUE` | والٹ کو مرموز، ری-کی، یا غیر مرموز کرتا ہے |

## مثالیں

```sh
# otpauth:// URI سے درآمد کریں (مثلاً QR کوڈ ایکسپورٹ سے)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# براہ راست Base32 سیکرٹ سے Steam Guard اندراج شامل کریں
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# موجودہ کوڈ حاصل کریں
./winauth-cli code steam

# والٹ میں موجود ہر چیز کی فہرست دیکھیں
./winauth-cli list

# والٹ کو پاس ورڈ سے مرموز کریں (ممکن ہو تو --password کے بجائے WINAUTH_PASSWORD استعمال کریں)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## والٹ کا مقام

بطور ڈیفالٹ، والٹ `~/.config/winauth-cli/winauth.xml` میں محفوظ ہوتا ہے۔ اس فائل کی اجازتیں سخت رکھیں (`chmod 600`)، کیونکہ اس میں آتھینٹیکیٹر سیکرٹس ہوتے ہیں، چاہے والٹ خود مرموز ہو یا نہ ہو۔
