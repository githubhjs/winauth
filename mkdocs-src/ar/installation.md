# التثبيت

## 1. الحصول على الإصدار

نزّل `winauth-cli-mono.zip` من [أحدث إصدار](https://github.com/githubhjs/winauth-running-on-all-OS.cli/releases/latest) وفكّ ضغطه:

```sh
unzip winauth-cli-mono.zip -d ~/tools/winauth-cli
```

## 2. تثبيت بيئة تشغيل Mono

**Linux (Ubuntu/Debian):**
```sh
sudo apt-get install -y mono-runtime
```

**macOS (Homebrew):**
```sh
brew install mono
```

**Windows:** تعمل أداة سطر الأوامر أيضًا مع .NET Framework القياسي الموجود مسبقًا في Windows — Mono مطلوب فقط لـ Linux/macOS.

## 3. التحقق

```sh
cd ~/tools/winauth-cli/winauth-cli
./winauth-cli --help
```

تم تأكيد العمل على Linux ARM64 (Ubuntu، عبر `mono-runtime`) و macOS (عبر Homebrew `mono`).
