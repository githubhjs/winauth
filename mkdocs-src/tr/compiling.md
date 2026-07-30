# Nasıl derlenir

## Windows GUI (Visual Studio) — köken referansı olarak korunan orijinal WinAuth

### Ön koşullar

* Visual Studio 2017
* Windows 8.1 SDK

### Kurulum

1. Visual Studio 2017'yi kurun. Yükleyicinin "Individual components" seçiminde "Windows 8.1 SDK"yı etkinleştirdiğinizden emin olun. [Ekran görüntüsüne](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) bakın.
2. Git ile klonlayın veya kod tabanını indirip çıkarın.

### Derleme

1. Başlamadan önce, veri kaybını önlemek için `%AppData%\WinAuth\winauth.xml` dosyasını yedekleyin veya kimlik doğrulayıcılarınızı dışa aktarın.
2. Visual Studio'da `Net4.5\WinAuth.sln` veya `Net3.5\WinAuth-Net3.5.sln` çözüm dosyasını açın.
3. Visual Studio > Build > Build Solution.
4. Başarılı olursa, çalıştırılabilir dosya çözüm dizinindeki `bin\Debug\WinAuth.exe` konumunda olacaktır.

## WinAuth.Cli (bu fork'un sürdürülen hedefi)

Yukarıdakiyle aynı `.sln` yapısı için Mono'nun `xbuild`/`msbuild` araçlarıyla `WinAuth.Cli` projesini derleyin. Yayınlanan `winauth-cli-mono.zip` sürüm dosyalarını üretmek için kullanılan tam CI derleme adımları için deponun release workflow'una bakın.
