# WinAuth CLI

`winauth-cli` is a GUI-free, AnyCPU command-line authenticator for Mono on Linux and macOS. It supports TOTP and HOTP accounts used by Google, Microsoft, Okta, Guild Wars, Battle.net, Trion, Steam and other RFC-compatible services through Base32 secrets or standard `otpauth://` URIs.

## Build and run

```sh
xbuild /property:Configuration=Release WinAuth.Cli/WinAuth.Cli.csproj
mono WinAuth.Cli/bin/Release/winauth-cli.exe help
```

The default vault is `~/.config/winauth/winauth.xml`. Use `--file` to select another vault. Use `passwd --new-password ...` to enable AES-256 encryption; for routine use, provide the password with `WINAUTH_PASSWORD` rather than a command-line argument.

```sh
mono WinAuth.Cli/bin/Release/winauth-cli.exe add --name email --issuer Example --secret JBSWY3DPEHPK3PXP
mono WinAuth.Cli/bin/Release/winauth-cli.exe import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
mono WinAuth.Cli/bin/Release/winauth-cli.exe list
mono WinAuth.Cli/bin/Release/winauth-cli.exe code email
```

`show` deliberately prints secret material. Redirect it to a protected file and avoid terminal history when appropriate. Hardware-backed YubiKey encryption, desktop notifications, clipboard access, hotkeys, and automatic online account enrollment are desktop/Windows integration features and are intentionally not performed by this headless client; provisioned secrets from all providers remain usable.
