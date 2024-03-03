# Các khái niệm cơ bản về lập trình

Overview

---

## Máy tính, chương trình và lập trình

### Sơ lược về máy tính điện tử

- Máy tính điện tử (electronic computer) là thiết bị điện tử có khả năng xử lý thông tin tự động theo chương trình lập sẵn.
- Máy tính điện tử ngày nay được chế tạo theo [kiến trúc Von Neumann](https://en.wikipedia.org/wiki/Von_Neumann_architecture).

[![Von Neumann architecture](img/Von_Neumann_Architecture.svg)](https://en.wikipedia.org/wiki/Von_Neumann_architecture#/media/File:Von_Neumann_Architecture.svg)

- Các thành phần chính của máy tính điện tử:
    - Bộ xử lý trung tâm (central processing unit) có chức năng điều khiển, thực hiện các tính toán số học và logic.
    - Bộ nhớ (memory) lưu trữ dữ liệu (data) và chương trình (programs).
    - Thiết bị nhập (input devices) nạp dữ liệu hoặc lệnh vào cho máy tính xử lý.
    - Thiết bị xuất (output devices) đưa kết quả xử lý ra.

### Đặc điểm cơ bản của máy tính điện tử

- Máy tính điện tử chỉ xử lý được các lệnh và dữ liệu được biểu diễn dưới dạng mã nhị phân.
- Tốc độ xử lý nhanh (hàng tỷ phép tính/giây).
- Hoạt động (xử lý dữ liệu) theo chương trình lập sẵn.

## Giải thuật và lập trình

- Khi cần giải quyết một bài toán, máy tính không tự nghĩ ra cách giải, mà con người cần xây dựng một dãy các lệnh theo trật tự xác định để máy tính thực hiện xử lý. Tập các lệnh được gọi là chương trình (program).
- Để giải quyết một bài toán bằng máy tính, con người cần thực hiện các bước cơ bản sau:
    - Phân tích bài toán, xác định yêu cầu: dữ kiện bài toán (input), kết quả cần tìm kiếm/tính toán (output);
    - Xây dựng giải thuật/thuật toán (algorithm): Vận dụng kiến thức liên quan để xây dựng dãy các hành động theo một thứ tự xác định để giải quyết bài toán;
    - Viết chương trình (programming/coding): Sử dụng ngôn ngữ lập trình phù hợp để cài đặt giải thuật thành chương trình máy tính.

## Ngôn ngữ lập trình

- Ngôn ngữ lập trình là loại phần mềm chuyên dụng dùng để tạo ra các chương trình máy tính. Một ngôn ngữ lập trình cung cấp các khai báo dữ liệu và các câu lệnh điều khiển, đồng thời có chức năng dịch các dòng lệnh thành ngôn ngữ máy để máy tính thi hành được.

### Các loại ngôn ngữ lập trình

- Ngôn ngữ máy ()

### Môi trường phát triển tích hợp (IDE)

### Ngôn ngữ lập trình Python

Ngày nay, Python là một trong những ngôn ngữ lập trình được sử dụng rộng rãi nhất trên thế giới. Các ưu điểm nổi bật của Python là:

- Python là ngôn ngữ thông dịch, hướng đối tượng.
- Python có cú pháp đơn giản, dễ hiểu. Chương trình Python dễ bảo trì, nâng cấp.
- Python hoạt động trên đa nền tảng: Windows, Linux và Mac.
- Khả năng mở rộng dễ dàng.

### Các ứng dụng của Python

Là ngôn ngữ lập trình đa dụng, Python được sử dụng rộng rãi trong nhiều lĩnh vực:

#### Lập trình hệ thống (system programming)
- Python cung cấp các thư viện dựng sẵn cho phép tạo các ứng dụng hệ thống gọn nhẹ, dễ bảo trì. Các loại ứng dụng bao gồm xử lý file, xử lý song song v.v..

#### Tạo ứng dụng GUI
- Python cung cấp giao tiếp chuẩn, hướng đối tượng liên kết đến thư viện đồ họa Tk GUI API (gọi là tkinter), cho khả năng tạo các ứng dụng GUI nhanh chóng. Một số thư viện khác gồm PyQt, PyGTK.

#### Lập trình ứng dụng Web/Internet
- Python cung cấp công cụ lập trình socket, truyền dữ liệu qua mạng,xử lý tài liệu XML, JSON, xử lý email, v.v..
Ngoài ra, có nhiều công cụ được phát triển bởi bên thứ 3 như Django, web2py.

#### Lập trình cơ sở dữ liệu

- Python cung cấp giao tiếp kết nối với các hệ quản trị cơ cơ sở dữ liệu quan hệ phổ biến như Oracle.

#### Lập trình xử lý bài toán khoa học

Python ngày nay được sử dụng trong các bài toán khoa học kỹ thuật, với các thư viện xử lý số rất mạnh như NumPy, SciPy.

#### Lập trình ứng dụng khoa học dữ liệu, trí tuệ nhân tạo, IoT

### Cơ chế hoạt động của Python

- Ngôn ngữ Python hoạt động theo cơ chế thông dịch. 
