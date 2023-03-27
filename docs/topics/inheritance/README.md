# Thừa kế

Inheritance

---

## Tổng quát hóa, đặc biệt hóa

Mối quan hệ tổng quát hóa hay đặc biệt hóa rất quen thuộc trong thế giới thực. Đối tượng đặc biệt hóa của một dạng đối tượng tổng quát sẽ có đầy đủ tính chất của lớp tổng quát đó, đồng thời có thêm các tính chất riêng của nó. Ví dụ, hình vuông là trường hợp đặc biệt của hình chữ nhật, hay nói ngược lại hình chữ nhật là trường hợp tổng quát của hình vuông. Trong lập trình hướng đối tượng, mối quan hệ tổng quát hóa, đặc biệt hóa được cài đặt thông qua kỹ thuật thừa kế (inheritance).

## Cài đặt thừa kế

Thừa kế là một đặc điểm quan trọng của lập trình hướng đối tượng, cho phép tạo lớp mới tái sử dụng các lớp đã có. Lớp cho phép thừa kế gọi là **lớp cơ sở (base class)** hay lớp cha (parent class), lớp hưởng thừa kế gọi là **lớp dẫn xuất (derived class)** hay lớp con (child class). Lớp thừa kế có thể sử dụng lại, sửa đổi hay mở rộng các thành phần của lớp cơ sở.

- Trong C# một lớp dẫn xuất chỉ được kế thừa một lớp cơ sở. Một lớp cơ sở có thể có nhiều lớp dẫn xuất.
- Có thể cài đặt thừa kế chuyển tiếp (transitive inheritance). Nếu lớp C kế thừa lớp B, lớp B kế thừa lớp A thì lớp C được sử dụng các thành viên (thuộc tính, phương thức) của lớp B và lớp A.
- Lớp dẫn xuất không được phép thừa kế phương thức thiết lập (constructor), hủy (finalizer) của lớp cơ sở.

### Cú pháp

```C#
<Phạm vi> class <Tên lớp dẫn xuất>: <Tên lớp cơ sở> 
{ 
  // Các thành phần dữ liệu
  // Các thành phần phương thức
}
```

### Ví dụ

```c#
// Cài đặt lớp Rectangle
public class Rectangle
{
    protected Width { get; set; }
    protected double Height { get; set; }
    // Hàm thiết lập 
    public Rectangle(double w = 0, double h = 0)
    {
        Width = w;
        Height = h;
    }
    // Hàm tính diện tích hình chữ nhật
    public double Area()
    {
        return Width * Height;
    }
}

// Xây dựng lớp Square kế thừa lớp Rectangle
public class Square : Rectangle
{
    // Hàm thiết lập
    public Square(double w = 0) : base(w, w) { }
}

// Chương trình chính
class Program
{
    static void Main()
    {
        // Tạo đối tượng hình chữ nhật
        Rectangle r1 = new Rectangle(3, 7);
        // In diện tích hình chữ nhật
        Console.WriteLine("Dien tich hinh chu nhat = {0}", r1.Area());

        // Tạo đối tượng hình vuông
        Square s1 = new Square(5);
        // In diện tích hình vuông
        double area = s1.Area();
        Console.WriteLine("Dien tich hinh vuong = {0}", area);
    }
}
```

Trong ví dụ trên, lớp Rectangle có hai thuộc tính Width, Height dùng để lưu chiều ngang, chiều cao của hình chữ nhật, phương thức tạo lập và phương thức `Area()` tính diện tích.

Do hình vuông là trường hợp đặc biệt của hình chữ nhật (khi chiều rộng và chiều cao bằng nhau), nên ta tạo lớp Square kế thừa lớp Rectangle để sử dụng lại những thành phần: chiều rộng, chiều cao, phương thức tính diện tích. Trong lớp Square chỉ cần cài đặt hàm thiết lập phù hợp với trường hợp đặc biệt hóa (bốn cạnh bằng nhau nên chỉ cần tạo lập một cạnh). Kết quả, ta có lớp hình vuông với đầy đủ các thuộc tính, phương thức mà không cần phải viết lại toàn bộ mã nguồn.

[Xem các ví dụ khác trên GitHub](https://github.com/nd-hung/oop/tree/main/docs/topics/inheritance/code)

## Quy tắc thừa kế

- Thành viên (thuộc tính, phương thức) có mức độ `private` không cho phép truy cập từ ngoài lớp.
- Thành viên có mức độ `protected` cho phép các lớp dẫn xuất sử dụng.
- Thành viên có mức độ `internal` cho phép lớp dẫn xuất trong cùng assembly với lớp cơ sở sử dụng.
- Thành viên có mức độ `public` cho phép sử dụng tự do từ ngoài lớp.

## Lớp niêm phong (sealed class)

Khi muốn tạo một lớp không cho lớp khác thừa kế, thêm từa khóa `sealed` trước định nghĩa tên lớp.

Ví dụ:

```c#
public sealed class Square
{
    // Class members here.
}
```

## Ghi đè phương thức (Method overriding)

Ví dụ ([Xem mã nguồn trên GitHub](https://github.com/nd-hung/oop/blob/main/docs/topics/inheritance/code/MethodOverriding/Program.cs)):

```c#
// Định nghĩa lớp Shape mô tả các hình vẽ tổng quát
public class Shape
{
    protected string name; 
    public string Name { get => name; }
    // Hàm thiết lập
    public Shape(string name = "Shape")
    { this.name = name; }
    // Hàm tính diện tích - Hàm ảo (virtual)
    // Shape chưa phải hình vẽ cụ thể nên chưa thể tính diện tích
    public virtual double Area()
    {        
        return 0;
    }
} // Kết thúc lớp Shape

// Định nghĩa lớp Square mô tả các hình vuông, kế thừa lớp Shape
public class Square : Shape
{
    // Hình vuông có thuộc tính độ dài cạnh
    private double side;
    public double Side { get => side; }

    // Hàm thiết lập: khởi tạo tên gọi và độ dài cạnh hình vuông
    public Square(string name = "Square", double side = 0) : base(name)
    {
        this.side = side;
    }

    // Hàm tính diện tích - Ghi đè hàm cùng tên của lớp Shape
    public override double Area()
    {
        // Ở đây là hình vẽ cụ thể (hình vuông) nên tính được diện tích
        return side * side;
    }
} // Kết thúc lớp Square

// Định nghĩa lớp Circle mô tả các hình tròn, kế thừa lớp Shape
public class Circle : Shape
{
    // Hình tròn có thuộc tính độ dài bán kính
    private double radius;
    public double Radius { get => radius; }

    // Hàm thiết lập: khởi tạo tên gọi và độ dài bán kính hình tròn
    public Circle(string name = "Circle", double radius = 0) : base(name)
    {
        this.radius = radius;
    }

    // Hàm tính diện tích - Ghi đè hàm cùng tên của lớp Shape
    public override double Area()
    {
        // Ở đây là hình vẽ cụ thể (hình tròn) nên tính được diện tích
        return Math.PI * radius * radius;
    }
} // Kết thúc lớp Circle

// Chương trình chính
internal class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng hình vẽ
        Shape shape = new Shape("General shape");
        Console.WriteLine("This is a {0}, area = {1:0.00}", shape.Name, shape.Area());

        // Tạo đối tượng hình vuông
        Shape square = new Square("Square", 5);
        Console.WriteLine("This is a {0}, area = {1:0.00}", square.Name, square.Area());

        // Tạo đối tượng hình tròn
        Shape circle = new Circle("Circle", 1);
        Console.WriteLine("This is a {0}, area = {1:0.00}", circle.Name, circle.Area());
    }
}
```

![Ví dụ chạy chương trình](code/MethodOverriding/img/run_example.PNG)