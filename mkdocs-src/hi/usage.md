# CLI उपयोग

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

ग्लोबल विकल्प:

| विकल्प | विवरण |
|---|---|
| `--file PATH` | वॉल्ट XML फ़ाइल का पाथ (डिफ़ॉल्ट `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | वॉल्ट पासवर्ड, अगर एन्क्रिप्टेड हो। कमांड लाइन पर पास करने के बजाय एनवायरनमेंट वेरिएबल `WINAUTH_PASSWORD` इस्तेमाल करना बेहतर है — इससे पासवर्ड प्रोसेस लिस्ट में एक्सपोज़ नहीं होता। |

## कमांड

| कमांड | विवरण |
|---|---|
| `list` | वॉल्ट की सभी एंट्रीज़ लिस्ट करें |
| `code NAME\|ID` | किसी एंट्री का मौजूदा TOTP/HOTP/Steam Guard कोड दिखाएँ |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | मैन्युअली नई एंट्री जोड़ें |
| `import --uri otpauth://...` | स्टैंडर्ड `otpauth://` URI से एंट्री इम्पोर्ट करें |
| `show NAME\|ID` | एंट्री का `otpauth://` URI दिखाएँ |
| `rename NAME\|ID NEW_NAME` | एंट्री का नाम बदलें |
| `remove NAME\|ID` | एंट्री हटाएँ |
| `sync NAME\|ID COUNTER` | HOTP काउंटर वैल्यू सेट करें |
| `export DESTINATION` | वॉल्ट एक्सपोर्ट करें |
| `passwd --new-password VALUE` | वॉल्ट को एन्क्रिप्ट करें, री-की करें, या डिक्रिप्ट करें |

## उदाहरण

```sh
# otpauth:// URI से इम्पोर्ट करें (जैसे QR कोड एक्सपोर्ट से)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 सीक्रेट से सीधे Steam Guard एंट्री जोड़ें
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# मौजूदा कोड प्राप्त करें
./winauth-cli code steam

# वॉल्ट में सब कुछ लिस्ट करें
./winauth-cli list

# वॉल्ट को पासवर्ड से एन्क्रिप्ट करें (जहाँ संभव हो --password की जगह WINAUTH_PASSWORD इस्तेमाल करें)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## वॉल्ट की लोकेशन

डिफ़ॉल्ट रूप से वॉल्ट `~/.config/winauth-cli/winauth.xml` में सेव होता है। इस फ़ाइल की परमिशन सख़्त रखें (`chmod 600`), क्योंकि इसमें ऑथेंटिकेटर सीक्रेट्स होते हैं, चाहे वॉल्ट ख़ुद एन्क्रिप्टेड हो या न हो।
