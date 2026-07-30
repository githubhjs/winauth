# Matumizi ya CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Chaguo za jumla:

| Chaguo | Maelezo |
|---|---|
| `--file PATH` | Njia ya faili la XML la hifadhi (chaguo-msingi `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Nywila ya hifadhi, kama imesimbwa. Ni bora kutumia kigezo cha mazingira `WINAUTH_PASSWORD` badala ya kuipitisha kwenye mstari wa amri — hii huepuka kufichua nywila kwenye orodha ya michakato. |

## Amri

| Amri | Maelezo |
|---|---|
| `list` | Inaorodhesha maingizo yote kwenye hifadhi |
| `code NAME\|ID` | Inaonyesha msimbo wa sasa wa TOTP/HOTP/Steam Guard wa ingizo |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Inaongeza ingizo jipya kwa mkono |
| `import --uri otpauth://...` | Inaingiza ingizo kutoka URI ya kawaida ya `otpauth://` |
| `show NAME\|ID` | Inaonyesha URI ya `otpauth://` ya ingizo |
| `rename NAME\|ID NEW_NAME` | Inabadilisha jina la ingizo |
| `remove NAME\|ID` | Inaondoa ingizo |
| `sync NAME\|ID COUNTER` | Inaweka thamani ya kihesabu cha HOTP |
| `export DESTINATION` | Inahamisha (export) hifadhi |
| `passwd --new-password VALUE` | Inasimba, kubadilisha ufunguo, au kufungua hifadhi |

## Mifano

```sh
# Kuingiza kutoka URI ya otpauth:// (mfano kutoka uhamishaji wa msimbo wa QR)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Ongeza ingizo la Steam Guard moja kwa moja kutoka siri ya Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Pata msimbo wa sasa
./winauth-cli code steam

# Orodhesha kila kitu kwenye hifadhi
./winauth-cli list

# Simba hifadhi kwa nywila (tumia WINAUTH_PASSWORD badala ya --password inapowezekana)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Mahali pa hifadhi

Kwa chaguo-msingi, hifadhi huhifadhiwa katika `~/.config/winauth-cli/winauth.xml`. Weka ruhusa za faili hili kali (`chmod 600`), kwani lina siri za uthibitishaji, iwe hifadhi yenyewe imesimbwa au la.
