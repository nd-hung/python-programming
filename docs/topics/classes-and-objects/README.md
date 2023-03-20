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

Thuộc tính truy cập (access modifier) thể hiện mức độ che chắn đến lớp và các thành viên của lớp.

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

### Tạo đối tượng

- Cần tạo đối tượng trước khi sử dụng.

- Cú pháp

```c#
<Tên lớp> <Tên đối tượng> = new <Tên lớp>([<Các tham số khởi tạo>]);
```

- Có thể xem lớp là kiểu dữ liệu tự định nghĩa, và mỗi đối tượng là một biến thuộc kiểu dữ liệu đó.
- Có thể tạo nhiều đối tượng của cùng một lớp, hoặc tạo mảng hoặc tập hợp các đối tượng.
- Có thể tạo đối tượng kết hợp với khởi tạo các thuộc tính cho nó. Cần viết các hàm thiết lập (constructor) phù hợp để áp dụng tính năng này.

Ví dụ:

```c#
Dog vnDog = new Dog();
vnDog.Name = "Cau Vang";

Dog jpDog = new Dog();
jpDog.Name = "Shiba";
```

## Hàm thiết lập (constructor)

Phương thức thiết lập (constructor) là một hàm đặc biệt dùng để khởi tạo đối tượng. Khi một đối tượng được tạo ra, một hàm thiết lập phù hợp sẽ được gọi.

Hàm thiết lập trùng tên lớp, không có kiểu trả về, có thể có các tham số để khởi tạo giá trị cho các thuộc tính của đối tượng, phạm vi truy cập thường là public.

Một lớp có thể có nhiều hàm thiết lập khác nhau.

- Cú pháp

```c#
[public] <Tên lớp>([Danh sách tham số])
{
    // Các lệnh khởi tạo giá trị cho đối tượng
}
```

- Ví dụ

```c#
// Khai báo lớp mô tả xe hơi
public class Car
{
    public string? Manufacturer;    // Tên hãng sản xuất

    // Hàm thiết lập không tham số
    public Car()
    {
        Manufacturer = "Toyota";
    }

    // Hàm thiết lập có tham số
    public Car(string? mnf = "")
    {
        Manufacturer = mnf;
    }

    // Hàm in thông tin hãng xe
    public void Print()
    {
        Console.WriteLine("Manufacturer: " + Manufacturer);

    }
}

// Chương trình chính
class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng xe, gọi hàm thiết lập không tham số
        Car car1 = new Car();
        car1.Print();

        // Tạo đối tượng xe, gọi hàm thiết lập có tham số
        Car car2 = new Car("Ford");
        car2.Print();
    }
}
```

![Kết quả chạy chương trình](code/Car/img/run_example.PNG)

## Hàm hủy (destructor/finalizer)

Hàm hủy (destructor, trong C# gọi là finalizer) được gọi tự động khi đối tượng bị hủy.
Hàm hủy có chức năng dọn dẹp bộ nhớ, giải phóng tài nguyên.

Hàm hủy trùng tên lớp và có ký tự `~` ở trước, không có kiểu trả về, không có tham số, không có phạm vi truy cập.

Một lớp chỉ có một hàm hủy duy nhất.

- Cú pháp

```c#
~<Tên lớp>()
{
    // Các lệnh của hàm hủy
}
```

> Chú ý: NET 5 (gồm cả .NET Core) trở về sau không gọi hàm hủy khi kết thúc ứng dụng. Bạn có thể tạo ứng dụng với .NET Framework để kiểm nghiệm hoạt động của hàm hủy.
 
## Lớp tĩnh, thành phần tĩnh

### Lớp tĩnh

Khác với lớp thường, một lớp tĩnh (static class) không cho phép tạo ra các đối tượng (không thể dùng toán tử `new` để tạo đối tượng của lớp tĩnh).

Truy xuất thành viên của lớp tĩnh theo cú pháp `<Tên lớp>.<Tên thành viên>`.

Lớp tĩnh chỉ chứa các thành phần tĩnh.

Lớp tĩnh là lớp niêm phong (sealed), tức không cho phép thừa kế.

Lớp tĩnh phù hợp cho việc cài đặt thư viện các hàm xử lý với dữ liệu vào mà không cần truy xuất đến dữ liệu của lớp.

Ví dụ, trong thư viện lớp của .NET có lớp System.Math cài đặt sẵn nhiều hàm toán học để thuận tiện cho lập trình viên.

```c#
// Tính diện tích hình tròn, sử dụng hằng số PI và hàm lũy thừa Pow từ lớp tĩnh System.Math
double radius = 1.23;
double circleArea = Math.Pow(radius, 2) * Math.PI;
```

- Tạo lớp tĩnh

[Xem ví dụ trên GitHub](https://github.com/nd-hung/oop/blob/main/docs/topics/classes-and-objects/code/TemperatureConverter/Program.cs)

### Thành phần tĩnh

Một lớp có thể chứa các thành phần (thuộc tính, phương thức) tĩnh. Có thể gọi đến thành phần tĩnh của lớp không tĩnh cả khi chưa tạo đối tượng.

Cú pháp truy cập thành viên tĩnh: `<Tên_lớp>.<Tên_thành_viên_tĩnh>`

Chỉ có một bản sao duy nhất của thành phần tĩnh, bất kể có bao nhiêu đối tượng được tạo ra.

Việc khai báo một lớp không tĩnh có một số thành viên tĩnh phổ biến hơn trường hợp khai báo toàn bộ lớp là tĩnh. Hai trường hợp sử dụng phổ biến của thành phần tĩnh là để lưu số lượng đối tượng đã được khởi tạo hoặc để lưu trữ một giá trị được chia sẻ chung cho tất cả đối tượng trong lớp.

Ví dụ:

```c#
// Minh họa thành phần tĩnh của lớp không tĩnh
public class Dog    // Khai báo lớp mô tả loài chó
{
    public string Name { get; set; }      // Tên
    public static int Count = 0;          // Biến tĩnh để chứa tổng số đối tượng (chó) được tạo ra

    public Dog(string name = "")          // Hàm thiết lập
    {
        Name = name; 
        Count++;                          // Mỗi khi một đối tượng được tạo thì tăng số lượng thêm 1
    }
}

// Chương trình chính
class Program
{
    static void Main()
    {
        Dog dog1 = new Dog("Shiba");
        Dog dog2 = new Dog("Poodle");
        Dog dog3 = new Dog("Shepherd");
        // Truy xuất đến thành phần tĩnh theo cú pháp <Tên lớp>.<Tên thành phần tĩnh>
        Console.WriteLine("Total number of dogs: {0}", Dog.Count);
    }
}
```

## Con trỏ this

Từ khóa `this` tham chiếu đến đối tượng đang được xử lý.

Từ khóa `this` thường được dùng để phân biệt các thành phần cùng tên. Ví dụ:

```c#
public class NhanVien
{
    private string maNV;
    private string hoTenNV;

    public NhanVien(string maNV, string hoTenNV)
    {
        this.maNV = maNV;
        this.hoTenNV = hoTenNV;
    }
}
```

## Mảng các đối tượng

## Định nghĩa toán tử trên lớp
