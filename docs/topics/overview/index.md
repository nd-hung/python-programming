# Tổng quan
---

## Sơ lược các phương pháp lập trình

Các ứng dụng ngày càng đa dạng và phức tạp hơn, do đó các phương pháp và công cụ lập trình cũng cần có sự cải tiến để giải quyết hiệu quả.
Dựa theo "mô thức lập trình" (programming paradigms - phương pháp luận hay nguyên tắc chung cơ bản trong lập trình), các ngôn ngữ lập trình được chia thành hai nhóm chính: Lập trình hướng mệnh lệnh (imperative programming) và Lập trình khai báo (declarative programming).

### Lập trình hướng mệnh lệnh (imperative programming)

- Nguyên lý lập trình mệnh lệnh là *"how to do"* - ra lệnh máy tính thực hiện từng bước xử lý theo một trình tự xác định để đạt kết quả mong muốn, tương đồng với cách máy tính thực hiện ở mức mã máy (machine code).

- Chương trình được cài đặt theo trình tự của giải thuật, vì thế kiểu lập trình này còn gọi là lập trình giải thuật (algorithmic programming).

- Các phương pháp lập trình tuần tự, hướng thủ tục/cấu trúc (procedural/structured programming), lập trình hướng đối tượng (object-oriented programming) đều thuộc mô thức lập trình hướng mệnh lệnh.

### Lập trình khai báo (Declarative Programming)

Các ngôn ngữ lập trình khai báo diễn đạt các câu lệnh theo kiểu *"what to do"* - yêu cầu máy tính làm gì để đạt được kết quả mà không cần quan tâm đến cách thức thực hiện chi tiết. Các phân hệ của lập trình khai báo gồm có: Lập trình logic (như Prolog), hướng chức năng (như Haskell, Scala, F#), các ngôn ngữ chuyên biệt (domain-specific) như SQL, HTML.
## Phương pháp lập trình hướng đối tượng
### Cách tiếp cận hướng đối tượng
### Lập trình hướng đối tượng
## Lập trình hướng đối tượng vs Lập trình cấu trúc



<img src="figs/programming-paradigms-vi.png" alt="Programming paradigms" width="75%"> 




#### Lập trình tuần tự
- Chương trình là một dãy tuần tự các câu lệnh.

#### Lập trình hướng thủ tục/cấu trúc (procedural/structured programming)
- Là phương pháp lập trình dựa trên cách tiếp cận từ trên xuống (top-down development), từ tổng quát đến chi tiết. Theo đó, chương trình được chia thành các khối chức năng, các chức năng này nếu cần lại được phân chia tiếp thành các khối chức năng nhỏ hơn, cho đến khi các chức năng nhỏ nhất đủ đơn giản để cài đặt thành các chương trình con (thủ tục/hàm).
- Chương trình là sự kết hợp của các cấu trúc điều khiển: tuần tự (sequence), chọn lựa (selection) và lặp (repetition).
- Dữ liệu và xử lý tách rời nhau.

<details>
<summary>Ví dụ</summary>

<p>

```c#
/*
Minh họa lập trình cấu trúc với C#
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

// Khởi tạo một mảng số nguyên
int n=6;
int[] numbers = new int[] {3,8,2,1,6,5};

// Gọi hàm sắp xếp tăng dần
SapXepTD(numbers, n);

// Gọi hàm in mảng
InMang(numbers, n);

// Hàm sắp xếp mảng tăng dần
static void SapXepTD(int[] a, int n)
{
for(int i=0; i < n-1; i++)
    for(int j=i+1; j < n; j++)
        if(a[i] > a[j])
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
}

// Hàm in mảng
static void InMang(int[] a, int n)
{
    for(int i=0; i < n; i++)
        Console.Write("{0} ", a[i]);
}
```

</p>
</details>




<details>
<summary>Ví dụ</summary>
<p>

```c#
/*
Minh họa lập trình khai báo với C#
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

using System;
using System.Collections.Generic;

// Tạo một danh sách
List<int> numbers = new List<int> { 3, 8, 2, 1, 5, 6 };

// Gọi phương thức sắp xếp (tăng dần)
// Người lập trình không cần cài đặt hàm Sort()
numbers.Sort();

// Print the sorted list
Console.WriteLine("Day tang dan:");
Console.WriteLine("{0}", string.Join(", ", numbers));
```

</p>
</details>
<br>

<div class="info">
  <p>
  <ul>
    <li>
        Nhiều ngôn ngữ hỗ trợ đa mô thức (multi-paradigm), như: C++, Java, JavaScript, C#, PHP, Python.
    </li>
    <li>
        Một số ngôn ngữ chỉ hỗ trợ một mô thức lập trình (single-paradigm), như Smalltalk, Haskell.
    </li>
  </ul>
  </p>
</div>


<h2 id="oop"> Phương pháp lập trình hướng đối tượng </h2>

### Cách tiếp cận hướng đối tượng (Object Oriented Approach)
- Cách tiếp cận hướng đối tượng kết hợp dữ liệu và xử lý có liên quan với nhau vào một module.
- Thích hợp cho phát triển các hệ thống phức tạp và thay đổi nhanh chóng do:
    - Đáp ứng các thay đổi của hệ thống với chi phí thấp.
    - Khả năng tái sử dụng cao.
    - Tính module hóa cao, giúp đơn giản hóa việc phát triển các hệ thống lớn từ các thành phần đã có.

 - Các thành phần của hệ thống hướng đối tượng:
    - Đối tượng (objects). Một đối tượng là một thực thể được xác định bởi các thuộc tính và hành vi của nó. Các thực thể hữu hình (như sinh viên, giảng viên) hay vô hình (như tài khoản ngân hàng) đều có thể mô hình hóa dưới dạng đối tượng.
    - Thuộc tính (attributes): là các trường thông tin mô tả đối tượng.
    - Hành vi (behaviour): là cách đối tượng ứng xử với môi trường xung quanh. 
    - Lớp (class): là một nhóm các đối tượng có thuộc tính và hành vi tương tự nhau.
    - Phương thức (methods): là hành động xác định hành vi của một lớp đối tượng - là những hành động mà đối tượng có thể làm.
    - Thông điệp (message): là một phương thức tác động lên đối tượng để yêu cầu thực hiện hành động cụ thể. 

### Lập trình hướng đối tượng (Object Oriented Programming)
- Là phương pháp lập trình dựa trên cách tiếp cận hướng đối tượng.
- Chương trình là tập hợp các đối tượng. Đối tượng thực hiện các yêu cầu xử lý thông qua cơ chế truyền thông điệp (message passing). 
    * Thuộc tính: Là các thông tin mô tả đối tượng. Về mặt lập trình, việc khai báo các thuộc tính tương tự như khai báo biến, vì thế chúng còn được gọi là biến thành viên (member variables).
    * Phương thức: Là các hành vi mà đối tượng có thể thực hiện. Việc cài đặt các phương thức tương tự như các hàm, vì thế chúng còn được gọi là hàm thành viên (member functions).


<details>
<summary>Ví dụ</summary>
<p>

```c#
/*
Minh họa lập trình hướng đối tượng
Input: Mảng các số nguyên
Output: Mảng sắp xếp tăng dần
*/
using System;

// Khai báo lớp Array chứa mảng số nguyên và các xử lý trên mảng
public class Array{
    private int[] numbers; // Dữ liệu/biến thành viên

    // Phương thức (hàm) thiết lập (constructor)
    // Tạo một dãy n phần tử có giá trị ngẫu nhiên trong đoạn [Min, Max]
    public Array(int n, int min=0, int max=50)
    {
        numbers = new int[n];
        Random randNum = new Random();
        for(int i=0; i < numbers.Length; i++)
            numbers[i] = randNum.Next(min, max);
    }

    // Phương thức/Hàm thành viên
    public void Print()
    {
        Console.WriteLine("{0}", string.Join(", ", numbers));
    }

    // Sắp xếp tăng dần
    public void Sort()
    {   
        for(int i=0; i < numbers.Length - 1; i++)
            for(int j=i+1; j < numbers.Length; j++)
                if(numbers[i] > numbers[j])
                {
                    int t = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = t;
                }
    }
}

// Chương trình chính    
class Program
{
    static void Main(string[] args)
    {
        // Gọi phương thức thiết lập (constructor)
        // tạo mảng ngẫu nhiên các số nguyên trong khoảng [0, 30]
        Array myNumbers = new Array(6, 0, 30);
        
        // In mảng - gọi phương thức Print()
        Console.WriteLine("Random numbers:");
        myNumbers.Print();

        // Sắp xếp tăng dần - gọi phương thức Sort()
        myNumbers.Sort();

        // In mảng sau sắp xếp - gọi phương thức Print()
        Console.WriteLine("The numbers in ascending order:");
        myNumbers.Print();
    }
}
```

<img src="src/OOPExample/result.PNG">

</p>
</details>

### So sánh lập trình hướng đối tượng và lập trình cấu trúc
#### Bài toán minh họa
Để so sánh các cách tiếp cận lập trình, ta xét bài toán - đã đơn giản hóa - sau đây:

Một trường học cần xây dựng phần mềm quản lý đào tạo. Hệ thống này quản lý dữ liệu của sinh viên (Students), giảng viên (Lecturers), các môn học (Courses), và các kỳ thi (Exams). 
Phần mềm cần có các chức năng: thêm sinh viên (AddStudent), xóa sinh viên (RemoveStudent), dự thi (TakeExams), xem điểm (ViewGrades). 

Sau khi phân tích, mô hình hệ thống quản lý đào tạo được thiết kế theo sơ đồ sau:

<img src="figs/academicsystem.PNG" width="75%">

Hệ thống quản lý gồm có dữ liệu (data) và các chức năng (functions) thao tác trên dữ liệu. Trong đó, đường nét đứt thể hiện sự phụ thuộc của một tập dữ liệu vào một tập dữ liệu khác; chẳng hạn, mỗi sinh viên học nhiều môn học, mỗi môn học lại có nhiều sinh viên. Đường mũi tên thể hiện sự tác động của các chức năng lên một hoặc một số tập dữ liệu; ví dụ, chức năng thêm sinh viên (AddStudent) sẽ thay đổi nội dung của tập dữ liệu sinh viên (Students), còn chức năng dự thi (TakeExams) cần truy cập dữ liệu của cả sinh viên và kỳ thi (Exams). 

**Theo cách tiếp cận lập trình hướng thủ tục/cấu trúc**, mỗi chức năng được tổ chức thành một chương trình con (hàm) tương ứng. Các hàm thực hiện xử lý dữ liệu thông qua truyền tham số và trả về kết quả cho lời gọi hàm. 

Xét vài tình huống sau:
- *Tình huống 1*: Giả sử dữ liệu đang lưu trữ năm sinh là số có 2 chữ số, nay cần chuyển đổi thành số có 4 chữ số (ví dụ: 97 -> 1997).

Giải pháp hiển nhiên là cần thay đổi trường dữ liệu ngày sinh của sinh viên và giảng viên thành số có 4 chữ số. Khi đó, tất cả các hàm có tác động lên sinh viên và giảng viên sẽ không hoạt động được, trừ khi phải chỉnh sửa lại mã nguồn. Bên cạnh đó, tập dữ liệu sinh viên có mối quan hệ phụ thuộc với các tập dữ liệu khác, vì thế việc thay đổi này có thể gây ra lỗi cho hệ thống.

- *Tình huống 2*: Hệ thống cần quản lý thêm một thành phần dữ liệu mới là sinh viên hệ vừa làm vừa học.

Với phương pháp lập trình cấu trúc, cần thiết kế lại mô hình dữ liệu để bổ sung tập dữ liệu sinh viên vừa làm vừa học, sau đó viết các hàm xử lý tương ứng với mỗi chức năng cần có với tập dữ liệu mới này. 

Các tình huống trên cho thấy nhược điểm của phương pháp lập trình cấu trúc khi giải quyết những bài toán phức tạp. Khi đó, việc nâng cấp hay mở rộng trở nên khó khăn. Đồng thời, khả năng *tái sử dụng mã nguồn* và *sự che chắn dữ liệu* cũng hạn chế.

**Với cách tiếp cận hướng đối tượng**, các chức năng thêm sinh viên (AddStudent), xóa sinh viên (RemoveStudent) sẽ được đóng gói cùng với dữ liệu sinh viên (Students) trong một module. Với mỗi sinh viên, lớp Student sẽ tạo ra một thực thể tương ứng để lưu trữ, quản lý dữ liệu và các xử lý liên quan. Tương tự như vậy với các chức năng và tập dữ liệu khác.

<img src="figs/academicsystemoop.png" width="50%">

- Để yêu cầu một đối tượng thực hiện một hành động nào đó, cần truyền thông điệp cho nó (chính là gọi hàm tác động lên đối tượng). Chẳng hạn, khi một đối tượng sinh viên gọi chức năng "Add()",  chương trình sẽ tạo mới một đối tượng sinh viên, sau đó chức năng "AddAttendee()" sẽ được gọi từ một đối tượng của lớp môn học (Course). 


## Tài liệu tham khảo 

#### Lectures on High-performance Computing for Economists, University of Pennsylvania, 2020
#### Programming Languages, Stanford University, 2018
#### Object Oriented Analysis and Design using the UML, University of Calgary, 2000


