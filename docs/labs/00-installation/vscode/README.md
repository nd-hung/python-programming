## [Lập trình C# với Visual Studio Code](https://code.visualstudio.com/docs/languages/cpp)

### [Đặc điểm](#specs)
### [Cài đặt](#install)
### [Sử dụng](#use)

## Đặc điểm chính của Visual Studio Code <a name="specs"/>
- Gọn nhẹ, với nhiều tính năng cao cấp: gợi ý mã lệnh thông minh (IntelliSense code completion), quản lý phiên bản mã nguồn phân tán (Git).
- Khả năng mở rộng để lập trình với nhiều ngôn ngữ, gồm cả C#.
- Có thể chạy VS Code trên Windows, macOS và Linux.
- Miễn phí & mã nguồn mở. 
- VS Code là công cụ viết mã nguồn (code editor), không phải là IDE đầy đủ. Để lập trình C# với VS Code, cần cài đặt thêm các công cụ sau:
    * Gói mở rộng (extension) hỗ trợ viết mã nguồn C#.
    * .NET: VS Code hỗ trợ .NET Core, hoặc .NET Framework 4.5.2 trở lên.

## Cài đặt môi trường lập trình C# với VS Code trên Windows
### Cài đặt VS Code 
- [Tải về bản cài đặt VS Code cho Windows, bản cài đặt người dùng (User)](https://go.microsoft.com/fwlink/?LinkID=534107).
- Mở file cài đặt vừa tải xuống (tên file dạng `VSCodeUserSetup-{version}.exe`, chẳng hạn version=`x64-1.61.2`).
**License Agreement**: Chọn "Accept the agreement" và "Next".
<img src="figs/installvscode1.PNG">
**Ready to Install**: Chọn "Install".
<img src="figs/installvscode3.PNG">

<div class="note">
<p>
<ul>
<li>Ở chế độ cài đặt người dùng (User), VS Code sẽ được cài mặc định ở `C:\users\{username}\AppData\Local\Programs\Microsoft VS Code`, với `username` là tên tài khoản người dùng.</li>
<li>Muốn cài đặt VS Code cho tất cả người dùng, <a href="https://go.microsoft.com/fwlink/?linkid=852157">tải file cài đặt dành cho admin</a>. Khi đó VS Code sẽ được cài ở `Program Files`.
</ul>
</p>
</div>


### Cài C# extension
- Khởi động VS Code.
- Chọn biểu tượng "Extensions" (Ctrl+Shift+X), nhập C# vào ô tìm kiếm, chọn gói "C# for Visual Studio Code (powered by OmniSharp)" của Microsoft và nhấn "Install".

### Liên kết VS Code với tài khoản Github
- Chọn biểu tượng "Extensions" (Ctrl+Shift+X), nhập Github vào ô tìm kiếm, chọn gói "GitHub Pull Requests and Issues" của Github và nhấn "Install".
- 

## Lập trình C/C++ với VS Code <a name="use">
Tạo chương trình "Hello World" với VS Code.

- Khởi động VS Code.
- Mở cửa sổ Terminal bằng cách chọn **Terminal->New Terminal** (Ctrl+Shift+`).

Nhập các lệnh sau:
```console
mkdir HelloWorld
cd HelloWorld
code .
```
- **Bước 1**: Viết mã nguồn

Ở cửa số Explorer, chọn **New File** và nhập tên file là "helloworld.c".

<img src="figs/helloworld1.PNG">

Viết mã nguồn ở file "helloworld.c".
```c
// Hello World from VS Code and MinGW

#include <stdio.h>

int main()
{
    printf("Hello World from VS Code & MinGW!");
    return 0;
}
```

- **Bước 2**: Biên dịch

Chọn **Terminal->Run Build Task** (Ctrl+Shift+B) để biên dịch. Chọn trình biên dịch là "C:\msys64\mingw64\bin\gcc.exe".

<img src="figs/helloworld2.PNG">

Nếu không còn lỗi cú pháp, ở cửa sổ Terminal trình biên dịch báo "Build finished successfully". Nhấn phím bất kỳ để đóng lại.

- **Bước 3**: Chạy chương trình

Mở Terminal, nhập tên file thực thi "helloworld.exe" để chạy chương trình:

```console
.\helloworld
```
<img src="figs/helloworld3.PNG">
