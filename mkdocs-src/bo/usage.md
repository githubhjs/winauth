# CLI Usage

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

spyi-yongs gi gdam-kha:

| gdam-kha | 'grel-bshad |
|---|---|
| `--file PATH` | vault XML yig-cha'i lam (sngar-'jug `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | vault nang-cha byas na de'i password. command line thog 'jug pa las `WINAUTH_PASSWORD` mtshams-sbyor 'brel-yod (environment variable) be-chos byas na legs — 'dis password khyer-lugs (process) thog ton-pa 'gog thub |

## bka'-tshig

| bka'-tshig | 'grel-bshad |
|---|---|
| `list` | vault nang gi tho-gzhung tshang ma ston |
| `code NAME\|ID` | tho-gzhung zhig gi da-lta'i TOTP/HOTP/Steam Guard code ston |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | lag-thog nas tho-gzhung gsar-pa kha-snon byed |
| `import --uri otpauth://...` | tshad-ldan `otpauth://` URI nas tho-gzhung 'dren-'jug byed |
| `show NAME\|ID` | tho-gzhung zhig gi `otpauth://` URI ston |
| `rename NAME\|ID NEW_NAME` | tho-gzhung zhig gi ming bsgyur |
| `remove NAME\|ID` | tho-gzhung zhig sub |
| `sync NAME\|ID COUNTER` | HOTP counter gi grangs 'jug byed |
| `export DESTINATION` | vault phyir-'don byed |
| `passwd --new-password VALUE` | vault nang-cha, key gsar-pa, yang-na 'phyir-bsgyur byed |

## dpe-mtshon

```sh
# otpauth:// URI nas 'dren-'jug (dper na QR code phyir-'don nas)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 gsang-ba nas thad-kar Steam Guard tho-gzhung kha-snon
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# da-lta'i code len
./winauth-cli code steam

# vault nang gi thams-cad ston
./winauth-cli list

# vault password thog nang-cha byed (--password las WINAUTH_PASSWORD be-chos legs)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## vault gnas-sa

sngar-'jug thog vault ni `~/.config/winauth-cli/winauth.xml` nang nyar-tshags byed. vault rang-nyid nang-cha yin min ci yang rung, 'dir authenticator gsang-ba'i gnad-don yod pas yig-cha 'di'i cha-gnas (permission) mkhregs-po bzhag dgos (`chmod 600`)
