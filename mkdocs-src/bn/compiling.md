# কীভাবে কম্পাইল করবেন

## Windows GUI (Visual Studio) — মূল WinAuth, উৎস রেফারেন্স হিসেবে রাখা হয়েছে

### পূর্বশর্ত

* Visual Studio 2017
* Windows 8.1 SDK

### ইনস্টলেশন

1. Visual Studio 2017 ইনস্টল করুন। ইনস্টলারের "Individual components" নির্বাচনে "Windows 8.1 SDK" সক্রিয় করা নিশ্চিত করুন। [স্ক্রিনশট](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773) দেখুন।
2. git clone করুন অথবা কোডবেস ডাউনলোড করে এক্সট্র্যাক্ট করুন।

### বিল্ড করা

1. শুরু করার আগে, ডেটা হারানো এড়াতে `%AppData%\WinAuth\winauth.xml` ব্যাকআপ নিন অথবা আপনার অথেনটিকেটরগুলো এক্সপোর্ট করুন।
2. Visual Studio-তে `Net4.5\WinAuth.sln` অথবা `Net3.5\WinAuth-Net3.5.sln` সলিউশন ফাইল খুলুন।
3. Visual Studio > Build > Build Solution.
4. সফল হলে, এক্সিকিউটেবল ফাইলটি সলিউশন ডিরেক্টরিতে `bin\Debug\WinAuth.exe`-তে পাওয়া যাবে।

## WinAuth.Cli (এই ফর্কের রক্ষণাবেক্ষণ করা লক্ষ্য)

উপরের একই `.sln` কাঠামোর জন্য Mono-এর `xbuild`/`msbuild` দিয়ে `WinAuth.Cli` প্রজেক্ট বিল্ড করুন। প্রকাশিত `winauth-cli-mono.zip` রিলিজ আর্টিফ্যাক্ট তৈরি করতে ব্যবহৃত সঠিক CI বিল্ড ধাপগুলোর জন্য রিপোজিটরির রিলিজ ওয়ার্কফ্লো দেখুন।
