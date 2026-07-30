# winauth-cli

Fork multiplataforma e sem interface gráfica do [WinAuth](https://github.com/winauth/winauth) para usar segredos de autenticador exportados no Linux, macOS e Windows via Mono — sem necessidade da GUI do Windows.

Suporta TOTP/HOTP normal, além do formato de código de 5 caracteres do Steam Guard. As entradas são armazenadas em um cofre XML local, opcionalmente criptografado por senha.

## Início rápido

Baixe a versão mais recente:

<https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest>

```sh
unzip winauth-cli-mono.zip
cd winauth-cli
./winauth-cli import --uri 'otpauth://totp/Example:email?secret=JBSWY3DPEHPK3PXP&issuer=Example'
./winauth-cli add --type steam --name steam --secret JBSWY3DPEHPK3PXP
./winauth-cli code steam
```

Veja [Instalação](installation.md) para a configuração do Mono em cada plataforma, e [Uso do CLI](usage.md) para a referência completa de comandos.

## Por que este fork existe

O WinAuth original é uma aplicação GUI Windows Forms. Este fork extrai a lógica de autenticador/TOTP/HOTP/Steam Guard para `WinAuth.Cli`, uma ferramenta de linha de comando compatível com Mono, para que segredos de autenticador exportados (por exemplo, de um `.maFile`, uma exportação XML do WinAuth, ou qualquer URI `otpauth://`) possam ser usados sem interface em servidores, CI, ou máquinas não-Windows — verificado funcionando tanto em uma estação Linux ARM64 quanto no macOS.

O código-fonte original da GUI do Windows é mantido no repositório como referência de proveniência e compatibilidade, mas `WinAuth.Cli` é o alvo mantido deste fork.

## Autor

Fork mantido por Chih-Hsueh "Josh" HUANG ([huangjs@gmail.com](mailto:huangjs@gmail.com)).
