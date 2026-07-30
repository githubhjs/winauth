# sgrig-sbyor (Installation)

## 1. ཐོན་རིགས་ལེན།

[ཐོན་རིགས་གསར་ཤོས་](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) ནས་ `winauth-cli-mono.zip` ཕབ་ལེན་བྱོས་ལ་ཕྱེ་བཤིག་བྱོས།

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. Mono runtime sgrig-sbyor byos

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** CLI འདི་ Windows ཐོག་ཡོད་ཟིན་པའི་ tshad-ldan .NET Framework དང་ཡང་ལས་ཀ་བྱེད། Mono ནི་ Linux/macOS ཆེད་དུ་རྐྱང་པ་དགོས།

## 3. brtag-dpyad (Verify)

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

ARM64 Linux (Ubuntu, `mono-runtime` བརྒྱུད) དང་ macOS (Homebrew `mono` བརྒྱུད) ཐོག་ལེགས་པར་ལས་ཀ་བྱེད་པ་བརྟག་དཔྱད་བྱས་ཟིན།
