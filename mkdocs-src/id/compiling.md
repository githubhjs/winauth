# Cara mengompilasi

## GUI Windows (Visual Studio) — WinAuth asli, dipertahankan sebagai referensi asal-usul

### Prasyarat

* Visual Studio 2017
* Windows 8.1 SDK

### Instalasi

1. Instal Visual Studio 2017. Pada pemilihan "Individual components" di installer, pastikan untuk mengaktifkan "Windows 8.1 SDK". Lihat [screenshot](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Clone dengan git atau unduh dan ekstrak kode sumber.

### Build

1. Sebelum memulai, pastikan untuk mencadangkan `%AppData%\WinAuth\winauth.xml` atau mengekspor authenticator Anda untuk mencegah kehilangan data.
2. Buka file solution `Net4.5\WinAuth.sln` atau `Net3.5\WinAuth-Net3.5.sln` di Visual Studio.
3. Visual Studio > Build > Build Solution.
4. Jika berhasil, file eksekusi akan berada di `bin\Debug\WinAuth.exe` di direktori solution.

## WinAuth.Cli (target yang dipelihara dari fork ini)

Build dengan `xbuild`/`msbuild` Mono untuk proyek `WinAuth.Cli`, menggunakan struktur `.sln` yang sama seperti di atas. Lihat release workflow repositori untuk langkah-langkah build CI yang tepat yang digunakan untuk menghasilkan artefak rilis `winauth-cli-mono.zip` yang dipublikasikan.
