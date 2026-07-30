# CLI వినియోగం

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

గ్లోబల్ ఎంపికలు:

| ఎంపిక | వివరణ |
|---|---|
| `--file PATH` | వాల్ట్ XML ఫైల్ పాత్ (డిఫాల్ట్ `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | వాల్ట్ ఎన్‌క్రిప్ట్ చేయబడితే దాని పాస్‌వర్డ్. కమాండ్ లైన్‌లో ఇవ్వడం కంటే ఎన్విరాన్మెంట్ వేరియబుల్ `WINAUTH_PASSWORD` ఉపయోగించడం మంచిది — దీనివల్ల పాస్‌వర్డ్ ప్రాసెస్ లిస్ట్‌లో బహిర్గతం కాదు. |

## కమాండ్‌లు

| కమాండ్ | వివరణ |
|---|---|
| `list` | వాల్ట్‌లోని అన్ని ఎంట్రీలను జాబితా చేస్తుంది |
| `code NAME\|ID` | ఒక ఎంట్రీ యొక్క ప్రస్తుత TOTP/HOTP/Steam Guard కోడ్‌ను చూపుతుంది |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | మాన్యువల్‌గా కొత్త ఎంట్రీని జోడిస్తుంది |
| `import --uri otpauth://...` | ప్రామాణిక `otpauth://` URI నుండి ఎంట్రీని దిగుమతి చేస్తుంది |
| `show NAME\|ID` | ఒక ఎంట్రీ యొక్క `otpauth://` URI చూపుతుంది |
| `rename NAME\|ID NEW_NAME` | ఒక ఎంట్రీ పేరు మార్చుతుంది |
| `remove NAME\|ID` | ఒక ఎంట్రీని తొలగిస్తుంది |
| `sync NAME\|ID COUNTER` | HOTP కౌంటర్ విలువను సెట్ చేస్తుంది |
| `export DESTINATION` | వాల్ట్‌ను ఎగుమతి చేస్తుంది |
| `passwd --new-password VALUE` | వాల్ట్‌ను ఎన్‌క్రిప్ట్, రీ-కీ, లేదా డిక్రిప్ట్ చేస్తుంది |

## ఉదాహరణలు

```sh
# otpauth:// URI నుండి దిగుమతి చేయండి (ఉదా. QR కోడ్ ఎగుమతి నుండి)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 సీక్రెట్ నుండి నేరుగా Steam Guard ఎంట్రీని జోడించండి
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# ప్రస్తుత కోడ్‌ను పొందండి
./winauth-cli code steam

# వాల్ట్‌లోని ప్రతిదాన్ని జాబితా చేయండి
./winauth-cli list

# వాల్ట్‌ను పాస్‌వర్డ్‌తో ఎన్‌క్రిప్ట్ చేయండి (వీలైతే --password కంటే WINAUTH_PASSWORD ఉపయోగించండి)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## వాల్ట్ స్థానం

డిఫాల్ట్‌గా, వాల్ట్ `~/.config/winauth-cli/winauth.xml`లో నిల్వ చేయబడుతుంది. వాల్ట్ స్వయంగా ఎన్‌క్రిప్ట్ చేయబడినా లేకపోయినా, ఇందులో ఆథెంటికేటర్ సీక్రెట్‌లు ఉంటాయి కాబట్టి ఈ ఫైల్ అనుమతులను కఠినంగా ఉంచండి (`chmod 600`).
