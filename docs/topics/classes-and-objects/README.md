# Lớp và đối tượng

Classes and Objects

---

## Cài đặt lớp
### Cú pháp

```csharp
[Thuộc tính truy cập] class <Tên lớp>
{
    // Khai báo các thuộc tính và phương thức
}
```

- Thuộc tính truy cập (access modifier):

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
        Console.WriteLine(dog.Name);
    }
}
```

Trong đoạn code trên, lớp `Dog` được khai báo là `public`, thuộc tính `Name` cũng được khai báo `public`. Vì thế, trong lớp Program có thể sử dụng lớp Dog và có toàn quyền truy cập đến thuộc tính Name (đọc/ghi).

Nếu đổi mức độ truy cập của lớp `Dog` thành `private` thì khi biên dịch, lệnh `Dog dog = new Dog()` sẽ báo lỗi là `'Dog' is inaccessible due to its protection level` và lệnh `dog.Name = "Cau Vang"` sẽ báo lỗi `Dog.Name' is inaccessible due to its protection level`.

Nếu đổi mức độ truy cập của lớp `Dog` thành `public` và của thuộc tính `Name` thành `private` thì khi biên dịch, lệnh `Dog dog = new Dog()` hợp lệ, nhưng lệnh `dog.Name = "Cau Vang"` sẽ báo lỗi `'Dog.Name' is inaccessible due to its protection level`.



### Ví dụ

```cs
// Khai báo lớp xe hơi 
public class Car
{
   // Khai báo các trường (fiels), thuộc tính, phương thức...
}
```


## Thiết lập tính bao đóng 
## Tạo, sử dụng và hủy đối tượng
## Hàm thiết lập, hàm hủy
## Thành phần tĩnh
## Thành phần dữ liệu có kiểu là lớp
## Con trỏ this
## Mảng các đối tượng
## Định nghĩa toán tử trên lớp