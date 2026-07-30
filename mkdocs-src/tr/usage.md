# CLI Kullanımı

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Genel seçenekler:

| Seçenek | Açıklama |
|---|---|
| `--file PATH` | Kasa XML dosyasının yolu (varsayılan `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Kasa şifrelenmişse parolası. Parolayı komut satırında geçirmek yerine `WINAUTH_PASSWORD` ortam değişkenini kullanmak tercih edilir — bu, parolanın işlem listesinde görünmesini önler. |

## Komutlar

| Komut | Açıklama |
|---|---|
| `list` | Kasadaki tüm girişleri listeler |
| `code NAME\|ID` | Bir girişin güncel TOTP/HOTP/Steam Guard kodunu gösterir |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Manuel olarak yeni bir giriş ekler |
| `import --uri otpauth://...` | Standart bir `otpauth://` URI'sinden giriş içe aktarır |
| `show NAME\|ID` | Bir girişin `otpauth://` URI'sini gösterir |
| `rename NAME\|ID NEW_NAME` | Bir girişi yeniden adlandırır |
| `remove NAME\|ID` | Bir girişi kaldırır |
| `sync NAME\|ID COUNTER` | Bir HOTP sayaç değeri ayarlar |
| `export DESTINATION` | Kasayı dışa aktarır |
| `passwd --new-password VALUE` | Kasayı şifreler, anahtarı yeniler veya şifresini çözer |

## Örnekler

```sh
# Bir otpauth:// URI'sinden içe aktarma (ör. bir QR kod dışa aktarımından)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Base32 sırrından doğrudan bir Steam Guard girişi ekleme
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Güncel kodu alma
./winauth-cli code steam

# Kasadaki her şeyi listeleme
./winauth-cli list

# Kasayı bir parolayla şifreleme (mümkünse --password yerine WINAUTH_PASSWORD kullanın)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Kasa konumu

Varsayılan olarak kasa `~/.config/winauth-cli/winauth.xml` içinde saklanır. Kasanın kendisi şifreli olsun ya da olmasın, kimlik doğrulayıcı sırları içerdiğinden bu dosyanın izinlerini sıkı tutun (`chmod 600`).
