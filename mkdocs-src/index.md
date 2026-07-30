# winauth-cli

Cross-platform, GUI-free command-line fork of [WinAuth](https://github.com/winauth/winauth) for running exported authenticator secrets on Linux, macOS, and Windows through Mono — no Windows GUI required.

Supports normal TOTP/HOTP plus Steam Guard's 5-character code format. Entries are stored in a local, optionally password-encrypted XML vault.

## Quickstart

Download the latest release:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

See [Installation](installation.md) for Mono setup per platform, and [CLI Usage](usage.md) for the full command reference.

## Why this fork exists

The original WinAuth is a Windows Forms GUI application. This fork extracts the authenticator/TOTP/HOTP/Steam-Guard logic into `WinAuth.Cli`, a Mono-compatible command-line tool, so exported authenticator secrets (e.g. from a `.maFile`, a WinAuth XML export, or any `otpauth://` URI) can be used headlessly on servers, CI, or non-Windows machines — verified working on both an ARM64 Linux workstation and macOS.

The original Windows GUI source is retained in the repository for provenance and compatibility reference, but `WinAuth.Cli` is the maintained target of this fork.

## Author

Fork maintained by Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
