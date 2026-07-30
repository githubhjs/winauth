# winauth-cli

[WinAuth](https://github.com/winauth/winauth)'ın Mono aracılığıyla Linux, macOS ve Windows'ta dışa aktarılmış kimlik doğrulayıcı sırlarını kullanmaya yarayan, platformlar arası ve GUI'siz bir fork'u — Windows GUI'sine gerek yok.

Normal TOTP/HOTP'ye ek olarak Steam Guard'ın 5 karakterlik kod formatını da destekler. Girişler, isteğe bağlı olarak parola ile şifrelenebilen yerel bir XML kasasında saklanır.

## Hızlı başlangıç

En son sürümü indirin:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Her platform için Mono kurulumu için [Kurulum](installation.md) sayfasına, tam komut referansı için [CLI Kullanımı](usage.md) sayfasına bakın.

## Bu fork neden var

Orijinal WinAuth bir Windows Forms GUI uygulamasıdır. Bu fork, kimlik doğrulayıcı/TOTP/HOTP/Steam Guard mantığını Mono uyumlu bir komut satırı aracı olan `WinAuth.Cli`'ye çıkarır; böylece dışa aktarılmış kimlik doğrulayıcı sırları (örneğin bir `.maFile`'dan, WinAuth XML dışa aktarımından veya herhangi bir `otpauth://` URI'sinden) sunucularda, CI'da veya Windows olmayan makinelerde arayüzsüz olarak kullanılabilir — hem ARM64 Linux iş istasyonunda hem de macOS'ta çalıştığı doğrulanmıştır.

Orijinal Windows GUI kaynak kodu, köken ve uyumluluk referansı olarak depoda saklanmaya devam eder, ancak bu fork'un sürdürülen hedefi `WinAuth.Cli`'dir.

## Yazar

Bu fork Chih-Hsueh "Josh" HUANG tarafından sürdürülmektedir ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
