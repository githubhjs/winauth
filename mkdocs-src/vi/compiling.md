# Cách biên dịch

## GUI Windows (Visual Studio) — WinAuth gốc, được giữ lại để tham khảo nguồn gốc

### Yêu cầu

* Visual Studio 2017
* Windows 8.1 SDK

### Cài đặt

1. Cài đặt Visual Studio 2017. Trong phần chọn "Individual components" của trình cài đặt, hãy bật "Windows 8.1 SDK". Xem [ảnh chụp màn hình](https://stackoverflow.com/questions/43704734/how-to-fix-the-error-windows-sdk-version-8-1-was-not-found/43888773#43888773).
2. Clone bằng git hoặc tải xuống và giải nén mã nguồn.

### Xây dựng

1. Trước khi bắt đầu, hãy sao lưu `%AppData%\WinAuth\winauth.xml` hoặc xuất các trình xác thực của bạn để tránh mất dữ liệu.
2. Mở tệp solution `Net4.5\WinAuth.sln` hoặc `Net3.5\WinAuth-Net3.5.sln` trong Visual Studio.
3. Visual Studio > Build > Build Solution.
4. Nếu thành công, tệp thực thi sẽ nằm ở `bin\Debug\WinAuth.exe` trong thư mục solution.

## WinAuth.Cli (mục tiêu được duy trì của bản fork này)

Biên dịch bằng `xbuild`/`msbuild` của Mono cho dự án `WinAuth.Cli`, sử dụng cùng cấu trúc `.sln` như trên. Xem release workflow của kho mã để biết các bước build CI chính xác được dùng để tạo ra các tệp phát hành `winauth-cli-mono.zip` đã công bố.
