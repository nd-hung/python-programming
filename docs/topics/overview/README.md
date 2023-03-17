# Tổng quan

---

> Yêu cầu về phần mềm ngày càng trở nên đa dạng và phức tạp, đòi hỏi phương pháp lập trình hiệu quả để đáp ứng. Cho đến nay có hai phương pháp lập trình phổ biến nhất là **lập trình cấu trúc** và **lập trình hướng đối tượng**.

## Lập trình cấu trúc (structured programming)

> Phương pháp lập trình cấu trúc vận dụng cách tiếp cận từ trên xuống (top-down development), từ tổng quát đến chi tiết. Theo đó, chương trình được phân rã thành các chức năng riêng biệt, các chức năng này nếu cần lại có thể được chia nhỏ thành các chức năng nhỏ hơn. Mỗi chức năng con này được cài đặt thành một chương trình con tương ứng. Mỗi chương trình con có thể được gọi nhiều lần với các dữ liệu vào khác nhau.

> Ví dụ sau đây minh họa phương pháp lập trình cấu trúc. Cho một mảng số nguyên, sắp xếp mảng tăng dần, in mảng đã sắp xếp. Theo yêu cầu bài toán, chương trình được phân rã thành các chức năng: tạo mảng, sắp xếp mảng, in mảng.

<img src="code/structured-programming/img/top-down-approach.png" class="center">

[Mã nguồn](https://github.com/nd-hung/oop/blob/main/docs/topics/overview/code/structured-programming/Program.cs)

## Phương pháp lập trình hướng đối tượng (Object Oriented Programming)

- Là phương pháp lập trình dựa trên cách tiếp cận hướng đối tượng.
- Chương trình là tập hợp các đối tượng. Đối tượng thực hiện các yêu cầu xử lý thông qua cơ chế truyền thông điệp (message passing).

    * Thuộc tính: Là các thông tin mô tả đối tượng. Về mặt lập trình, việc khai báo các thuộc tính tương tự như khai báo biến, vì thế chúng còn được gọi là biến thành viên (member variables).
    * Phương thức: Là các hành vi mà đối tượng có thể thực hiện. Việc cài đặt các phương thức tương tự như các hàm, vì thế chúng còn được gọi là hàm thành viên (member functions).



## So sánh Lập trình hướng đối tượng và Lập trình cấu trúc
