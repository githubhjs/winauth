# Comment compiler

## GUI Windows (Visual Studio) — WinAuth original, conservé pour la provenance

### Prérequis

* Visual Studio 2017
* Windows 8.1 SDK

### Installation

1. Installez Visual Studio 2017. Dans la sélection des « Composants individuels » de l'installateur, assurez-vous d'activer « Windows 8.1 SDK ». Voir [capture d'écran](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Clonez avec git ou téléchargez et extrayez le code source.

### Compilation

1. Avant de commencer, sauvegardez `%AppData%\WinAuth\winauth.xml` ou exportez vos authentificateurs pour éviter toute perte de données.
2. Ouvrez le fichier solution `Net4.5\WinAuth.sln` ou `Net3.5\WinAuth-Net3.5.sln` dans Visual Studio.
3. Visual Studio > Générer > Générer la solution.
4. En cas de succès, l'exécutable se trouvera dans `bin\Debug\WinAuth.exe` du répertoire de la solution.

## WinAuth.Cli (cible maintenue de ce fork)

Compilez avec `xbuild`/`msbuild` de Mono sur le projet `WinAuth.Cli`, en utilisant la même structure `.sln` que ci-dessus. Consultez le workflow de publication (release workflow) du dépôt pour les étapes CI exactes utilisées pour produire les artefacts `winauth-cli-mono.zip` publiés.
