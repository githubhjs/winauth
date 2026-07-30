# CLI वापर

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

ग्लोबल पर्याय:

| पर्याय | वर्णन |
|---|---|
| `--file PATH` | व्हॉल्ट XML फाइलचा पाथ (डिफॉल्ट `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | व्हॉल्ट एन्क्रिप्टेड असल्यास त्याचा पासवर्ड. कमांड लाइनवर देण्याऐवजी एन्व्हायर्न्मेंट व्हेरिएबल `WINAUTH_PASSWORD` वापरणे चांगले — यामुळे पासवर्ड प्रोसेस लिस्टमध्ये उघड होत नाही. |

## कमांड्स

| कमांड | वर्णन |
|---|---|
| `list` | व्हॉल्टमधील सर्व एंट्रीज सूचीबद्ध करते |
| `code NAME\|ID` | एंट्रीचा सध्याचा TOTP/HOTP/Steam Guard कोड दाखवते |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | मॅन्युअली नवीन एंट्री जोडते |
| `import --uri otpauth://...` | स्टँडर्ड `otpauth://` URI मधून एंट्री इम्पोर्ट करते |
| `show NAME\|ID` | एंट्रीचा `otpauth://` URI दाखवते |
| `rename NAME\|ID NEW_NAME` | एंट्रीचे नाव बदलते |
| `remove NAME\|ID` | एंट्री काढून टाकते |
| `sync NAME\|ID COUNTER` | HOTP काउंटर व्हॅल्यू सेट करते |
| `export DESTINATION` | व्हॉल्ट एक्सपोर्ट करते |
| `passwd --new-password VALUE` | व्हॉल्ट एन्क्रिप्ट, री-की, किंवा डिक्रिप्ट करते |

## उदाहरणे

```sh
# otpauth:// URI मधून इम्पोर्ट करा (उदा. QR कोड एक्सपोर्टमधून)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 सिक्रेटमधून थेट Steam Guard एंट्री जोडा
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# सध्याचा कोड मिळवा
./winauth-cli code steam

# व्हॉल्टमधील सर्वकाही सूचीबद्ध करा
./winauth-cli list

# व्हॉल्ट पासवर्डने एन्क्रिप्ट करा (शक्य असल्यास --password ऐवजी WINAUTH_PASSWORD वापरा)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## व्हॉल्टचे स्थान

डिफॉल्टनुसार, व्हॉल्ट `~/.config/winauth-cli/winauth.xml` मध्ये साठवला जातो. व्हॉल्ट स्वतः एन्क्रिप्टेड असो वा नसो, त्यात ऑथेंटिकेटर सिक्रेट्स असल्याने या फाइलच्या परवानग्या कडक ठेवा (`chmod 600`).
