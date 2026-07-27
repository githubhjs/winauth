# WinAuth CLI

`winauth-cli` is a GUI-free, AnyCPU command-line authenticator for Mono on Linux and macOS. It supports TOTP and HOTP accounts used by Google, Microsoft, Okta, Guild Wars, Battle.net, Trion, Steam and other RFC-compatible services through Base32 secrets or standard `otpauth://` URIs.

## Build and run

```sh
xbuild /property:Configuration=Release WinAuth.Cli/WinAuth.Cli.csproj
mono WinAuth.Cli/bin/Release/winauth-cli.exe help
```

Mono 4.6 or newer is recommended. The produced executable only uses framework
libraries, so no application-local dependency DLLs are required. On Linux and
macOS it is invoked with `mono`; it is not a native Mach-O or ELF executable.

The default vault is `~/.config/winauth/winauth.xml`. Use `--file` to select another vault. Use `passwd --new-password ...` to enable AES-256 encryption; for routine use, provide the password with `WINAUTH_PASSWORD` rather than a command-line argument.

```sh
mono WinAuth.Cli/bin/Release/winauth-cli.exe add --name email --issuer Example --secret JBSWY3DPEHPK3PXP
mono WinAuth.Cli/bin/Release/winauth-cli.exe import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
mono WinAuth.Cli/bin/Release/winauth-cli.exe list
mono WinAuth.Cli/bin/Release/winauth-cli.exe code email
```

`show` deliberately prints secret material. Redirect it to a protected file and avoid terminal history when appropriate. Hardware-backed YubiKey encryption, desktop notifications, clipboard access, hotkeys, and automatic online account enrollment are desktop/Windows integration features and are intentionally not performed by this headless client; provisioned secrets from all providers remain usable.

## Automated tests

The basic integration suite covers the published RFC 4226 HOTP vectors, vault
mutations, `otpauth://` import, TOTP shape, and encrypted-vault password
handling. After building, run it from the repository root:

```sh
bash WinAuth.Cli/tests/cli-tests.sh
```

GitHub Actions builds the project and runs this suite for every push and pull
request.

## Binary releases

Push a tag beginning with `cli-v` (for example, `cli-v1.0.0`) to create a
GitHub release automatically. The workflow publishes `winauth-cli-mono.zip`,
containing the AnyCPU executable, this README, and a Unix launcher. Extract the
archive and run:

```sh
./winauth-cli help
```

The release archive is also uploaded as a workflow artifact on ordinary pushes
and pull requests, which makes pre-release binaries available after a
successful test run.
