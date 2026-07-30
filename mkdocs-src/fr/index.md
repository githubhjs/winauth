# winauth-cli

Fork multiplateforme et sans interface graphique de [WinAuth](https://github.com/winauth/winauth) permettant d'utiliser des secrets d'authentificateur exportés sur Linux, macOS et Windows via Mono — sans interface graphique Windows.

Prend en charge le TOTP/HOTP classique ainsi que le format de code à 5 caractères de Steam Guard. Les entrées sont stockées dans un coffre XML local, chiffrable par mot de passe.

## Démarrage rapide

Téléchargez la dernière version :

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Voir [Installation](installation.md) pour la configuration de Mono selon la plateforme, et [Utilisation du CLI](usage.md) pour la référence complète des commandes.

## Pourquoi ce fork existe

Le WinAuth original est une application GUI Windows Forms. Ce fork extrait la logique d'authentificateur/TOTP/HOTP/Steam Guard dans `WinAuth.Cli`, un outil en ligne de commande compatible Mono, afin que les secrets d'authentificateur exportés (par exemple depuis un `.maFile`, un export XML WinAuth, ou toute URI `otpauth://`) puissent être utilisés sans interface sur des serveurs, en CI, ou sur des machines non-Windows — vérifié fonctionnel sur une station de travail Linux ARM64 et sur macOS.

Le code source de l'interface graphique Windows originale est conservé dans le dépôt à titre de provenance et de référence de compatibilité, mais `WinAuth.Cli` est la cible maintenue de ce fork.

## Auteur

Fork maintenu par Chih-Hsueh « Josh » HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
