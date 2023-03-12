# Lớp và đối tượng

Classes and Objects

---

Hai khái niệm cơ bản của lập trình hướng đối tượng là lớp và đối tượng. Phần này tóm lược kỹ thuật cài đặt và sử dụng lớp và đối tượng với C#.

## Cài đặt lớp
- Cú pháp

```csharp
[Thuộc tính truy cập] class <Tên lớp>
{
    // Khai báo các thuộc tính và phương thức
}
```

## Thiết lập tính bao đóng

Thuộc tính truy cập (access modifier) thể hiện mức độ che chắn (encapsulation) đến lớp và thành viên của lớp.

**public**: Mức độ này cho phép truy cập đến lớp hoặc thành viên của lớp (thuộc tính, phương thức) trong cùng một assembly (là tập hợp các khai báo và tài nguyên tạo thành một file thi hành được (.exe hoặc .dll)), hoặc từ một assembly khác tham chiếu đến nó.

Khi một thành viên của lớp có thuộc tính truy cập là public thì mức độ truy cập đến thành viên đó được xác định bằng thuộc tính truy cập của lớp.

Ví dụ:

```cs
// Khai báo lớp mô tả loài chó 
public class Dog
{
    public string Name;
}

// Chương trình chính
class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng của lớp 
        Dog dog = new Dog();
        // Thay đổi giá trị thuộc tính 
        dog.Name = "Cau Vang";
        // Đọc thuộc tính
        Console.WriteLine("The dog's name is " + dog.Name);
    }
}
```

Trong đoạn code trên, lớp `Dog` được khai báo là `public`, thuộc tính `Name` cũng được khai báo `public`. Vì thế, các dòng lệnh trong lớp `Program` có thể sử dụng lớp `Dog` và có toàn quyền truy cập (đọc/ghi) đến thuộc tính `Name`.

- **private**: Chỉ có thể truy xuất đến lớp và thành viên của lớp từ bên trong lớp đó.

Trong ví dụ trên, nếu đổi mức độ truy cập của lớp `Dog` thành `private` thì khi biên dịch, lệnh `Dog dog = new Dog()` sẽ báo lỗi là `'Dog' is inaccessible due to its protection level` và lệnh `dog.Name = "Cau Vang"` sẽ báo lỗi `Dog.Name' is inaccessible due to its protection level`.

Nếu đổi mức độ truy cập của lớp `Dog` thành `public` và của thuộc tính `Name` thành `private` thì khi biên dịch, lệnh `Dog dog = new Dog()` hợp lệ, nhưng lệnh `dog.Name = "Cau Vang"` sẽ báo lỗi `'Dog.Name' is inaccessible due to its protection level`.

- **protected**: Có thể truy xuất đến lớp và thành viên của lớp từ bên trong lớp đó hoặc từ lớp thừa kế nó.

- **internal**: Chỉ có thể truy xuất đến lớp và thành viên của lớp từ bên trong một assembly.

- **protected internal**: Có thể truy xuất đến lớp và thành viên của lớp từ bên trong assembly, hoặc từ một lớp thừa kế nó nằm trong một assembly khác.

- **private protected**: Chỉ có thể truy xuất đến lớp và thành viên của lớp từ lớp thừa kế trong cùng một assembly.

## Tạo, sử dụng và hủy đối tượng
## Hàm thiết lập, hàm hủy
## Thành phần tĩnh
## Thành phần dữ liệu có kiểu là lớp
## Con trỏ this
## Mảng các đối tượng
## Định nghĩa toán tử trên lớp