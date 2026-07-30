# Penggunaan CLI

```
WinAuth command line authenticator
Usage: winauth-cli [--file PATH] [--password VALUE] COMMAND
```

Opsi global:

| Opsi | Deskripsi |
|---|---|
| `--file PATH` | Path ke file XML vault (default `~/.config/winauth-cli/winauth.xml`) |
| `--password VALUE` | Kata sandi vault, jika terenkripsi. Lebih baik gunakan variabel lingkungan `WINAUTH_PASSWORD` daripada memasukkannya di command line — agar kata sandi tidak terekspos di daftar proses. |

## Perintah

| Perintah | Deskripsi |
|---|---|
| `list` | Menampilkan semua entri dalam vault |
| `code NAME\|ID` | Menampilkan kode TOTP/HOTP/Steam Guard terkini dari suatu entri |
| `add --name NAME --secret BASE32 [--type totp\|hotp\|steam] [--issuer TEXT] [--digits N] [--period N] [--counter N] [--algorithm SHA1\|SHA256\|SHA512]` | Menambahkan entri baru secara manual |
| `import --uri otpauth://...` | Mengimpor entri dari URI `otpauth://` standar |
| `show NAME\|ID` | Menampilkan URI `otpauth://` dari suatu entri |
| `rename NAME\|ID NEW_NAME` | Mengganti nama entri |
| `remove NAME\|ID` | Menghapus entri |
| `sync NAME\|ID COUNTER` | Mengatur nilai counter HOTP |
| `export DESTINATION` | Mengekspor vault |
| `passwd --new-password VALUE` | Mengenkripsi, mengganti kunci, atau mendekripsi vault |

## Contoh

```sh
# Impor dari URI otpauth:// (misalnya dari ekspor kode QR)
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'

# Tambahkan entri Steam Guard langsung dari secret Base32
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP

# Dapatkan kode saat ini
./winauth-cli code steam

# Tampilkan semua isi vault
./winauth-cli list

# Enkripsi vault dengan kata sandi (gunakan WINAUTH_PASSWORD daripada --password jika memungkinkan)
export WINAUTH_PASSWORD='your-vault-password'
./winauth-cli passwd --new-password "$WINAUTH_PASSWORD"
```

## Lokasi vault

Secara default, vault disimpan di `~/.config/winauth-cli/winauth.xml`. Jaga agar izin file ini tetap ketat (`chmod 600`), karena berisi secret authenticator, baik vault itu sendiri terenkripsi atau tidak.
