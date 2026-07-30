# winauth-cli

Fork lintas platform dan tanpa GUI dari [WinAuth](https://github.com/winauth/winauth) untuk menjalankan secret authenticator yang sudah diekspor di Linux, macOS, dan Windows melalui Mono — tanpa memerlukan GUI Windows.

Mendukung TOTP/HOTP biasa, ditambah format kode 5 karakter Steam Guard. Entri disimpan dalam vault XML lokal, yang bisa dienkripsi dengan kata sandi secara opsional.

## Mulai cepat

Unduh rilis terbaru:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Lihat [Instalasi](installation.md) untuk pengaturan Mono per platform, dan [Penggunaan CLI](usage.md) untuk referensi lengkap perintah.

## Mengapa fork ini dibuat

WinAuth asli adalah aplikasi GUI Windows Forms. Fork ini mengekstrak logika authenticator/TOTP/HOTP/Steam Guard ke dalam `WinAuth.Cli`, alat command-line yang kompatibel dengan Mono, sehingga secret authenticator yang diekspor (misalnya dari `.maFile`, ekspor XML WinAuth, atau URI `otpauth://` apa pun) dapat digunakan tanpa GUI di server, CI, atau mesin non-Windows — terverifikasi berjalan baik di workstation Linux ARM64 maupun macOS.

Kode sumber GUI Windows asli tetap disimpan di repositori sebagai referensi asal-usul dan kompatibilitas, tetapi `WinAuth.Cli` adalah target yang dipelihara dari fork ini.

## Penulis

Fork ini dipelihara oleh Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
