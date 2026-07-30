# winauth-cli

[WinAuth](https://github.com/winauth/winauth) ལས་ཐོན་པའི་གྲས་ཐིག་བརྒྱུད་ལམ་ཁག་ཏུ་སྤྱོད་ཆོག་པའི། GUI མེད་པའི་ shag ཐོག་མ་ནས་བརྩིགས་པའི་ཡོ་ཆས་ཤིག་ཡིན། Mono བརྒྱུད་ནས་ Linux, macOS, དང་ Windows ཐོག་ཏུ་ཕྱིར་བཏོན་བྱས་པའི་ ngo-sprod (authenticator) གསང་བའི་གནད་དོན་སྤྱོད་ཆོག Windows GUI དགོས་མེད།

TOTP/HOTP སྤྱིར་བཏང་བ་མ་ཟད། Steam Guard གྱི་ཡིག་འབྲུ 5 ཡོད་པའི་ code རྣམ་པ་ཡང་རྒྱབ་སྐྱོར་བྱེད། ཐོ་གཞུང་ཚང་མ་ས་གནས་ (local) XML ཛ་མཛོད་ (vault) ནང་ཉར་ཚགས་བྱེད་ཅིང་། གཞན་ཡང་གདམ་ཁ་ཡོད་པའི་ཐོག་ནས་ password ཐོག་ nang-cha (encrypt) བྱེད་ཐུབ།

## མགྱོགས་པོར་འགོ་བཙུགས།

ཐོན་རིགས་གསར་ཤོས་ཕབ་ལེན་བྱོས།

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

lam-lugs (platform) rer Mono sgrig-sbyor byed-tshul la [Installation](installation.md) la ltos, CLI bka'-tshig gi cha-tshang la [CLI Usage](usage.md) la ltos.

## ཅི་ཡིན་ན་ shag འདི་བཟོས་པ།

WinAuth ngo-ma ni Windows Forms GUI application ཞིག་ཡིན། shag འདིས་ authenticator/TOTP/HOTP/Steam Guard གྱི་ logic `WinAuth.Cli` ནང་དུ་ཕྱེད་ སྟོན་གྱིས་། Mono དང་མཐུན་པའི་ command-line ཡོ་ཆས་ཤིག་བཟོས་ཡོད། དེས་ན་ ཕྱིར་བཏོན་བྱས་པའི་ ngo-sprod གསང་བའི་གནད་དོན་ (dper na `.maFile`, WinAuth XML ཕྱིར་བཏོན, ཡང་ན་ `otpauth://` URI གང་ཡང་རུང་ནས་) server, CI, ཡང་ན་ Windows མིན་པའི་ khal-phran ནང་ GUI མེད་པར་སྤྱོད་ཆོག ARM64 Linux workstation དང་ macOS gnyis ka ལ་ལེགས་པར་ལས་ཀ་བྱེད་པ་བརྟག་དཔྱད་བྱས་ཟིན།

Windows GUI ངོ་མའི་ source code ནི་ ག་ཁུངས་དང་མཐུན་སྒྲིག་གི་ dpe-mtshon ཆེད་དུ་ mdzod-khang ནང་ཉར་ཡོད། འོན་ཀྱང་ shag འདིའི་ maintain byed-pa'i dmigs-yul ནི་ `WinAuth.Cli` ཡིན།

## རྩོམ་པ་པོ།

shag འདི་ Chih-Hsueh "Josh" HUANG གིས་ maintain བྱེད་ ([huangjs@gmail.com](mailto:huangjs@gmail.com))།
