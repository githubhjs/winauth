# CLI பயன்பாடு

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

பொதுவான விருப்பங்கள்:

| விருப்பம் | விளக்கம் |
|---|---|
| `--file PATH` | பெட்டக XML கோப்பின் பாதை (இயல்புநிலை `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | பெட்டகம் குறியாக்கம் செய்யப்பட்டிருந்தால் அதன் கடவுச்சொல். கட்டளை வரியில் கொடுப்பதற்குப் பதிலாக `WINAUTH_PASSWORD` சூழல் மாறியைப் பயன்படுத்துவது சிறந்தது — இது கடவுச்சொல் செயல்முறை பட்டியலில் வெளிப்படுவதைத் தவிர்க்கிறது. |

## கட்டளைகள்

| கட்டளை | விளக்கம் |
|---|---|
| `list` | பெட்டகத்தில் உள்ள அனைத்து உள்ளீடுகளையும் பட்டியலிடும் |
| `code NAME\|ID` | ஒரு உள்ளீட்டின் தற்போதைய TOTP/HOTP/Steam Guard குறியீட்டைக் காட்டும் |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | கைமுறையாக புதிய உள்ளீட்டைச் சேர்க்கும் |
| `import --uri otpauth://...` | நிலையான `otpauth://` URI-இலிருந்து ஒரு உள்ளீட்டை இறக்குமதி செய்யும் |
| `show NAME\|ID` | ஒரு உள்ளீட்டின் `otpauth://` URI ஐக் காட்டும் |
| `rename NAME\|ID NEW_NAME` | ஒரு உள்ளீட்டை மறுபெயரிடும் |
| `remove NAME\|ID` | ஒரு உள்ளீட்டை நீக்கும் |
| `sync NAME\|ID COUNTER` | ஒரு HOTP கவுன்டர் மதிப்பை அமைக்கும் |
| `export DESTINATION` | பெட்டகத்தை ஏற்றுமதி செய்யும் |
| `passwd --new-password VALUE` | பெட்டகத்தை குறியாக்கம், மறு-திறவுகோல், அல்லது குறியவிழ்ப்பு செய்யும் |

## எடுத்துக்காட்டுகள்

```sh
# otpauth:// URI-இலிருந்து இறக்குமதி (எ.கா. QR குறியீடு ஏற்றுமதியிலிருந்து)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 ரகசியத்திலிருந்து நேரடியாக Steam Guard உள்ளீட்டைச் சேர்க்கவும்
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# தற்போதைய குறியீட்டைப் பெறவும்
./winauth-cli code steam

# பெட்டகத்தில் உள்ள அனைத்தையும் பட்டியலிடவும்
./winauth-cli list

# பெட்டகத்தை கடவுச்சொல்லுடன் குறியாக்கம் செய்யவும் (முடிந்தால் --password க்கு பதிலாக WINAUTH_PASSWORD ஐப் பயன்படுத்தவும்)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## பெட்டகத்தின் இருப்பிடம்

இயல்புநிலையாக, பெட்டகம் `~/.config/winauth-cli/winauth.xml` இல் சேமிக்கப்படுகிறது. பெட்டகம் தானே குறியாக்கம் செய்யப்பட்டிருந்தாலும் இல்லாவிட்டாலும், இதில் அங்கீகார ரகசியங்கள் இருப்பதால் இந்தக் கோப்பின் அனுமதிகளை கண்டிப்பானதாக வைக்கவும் (`chmod 600`).
