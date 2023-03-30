# Đa hình

Polymorphism

---

## Giới thiệu

Cơ chế đa hình (polymorphism ~ many forms/shapes) được xem là đặc trưng quan trọng thứ ba của phương pháp lập trình hướng đối tượng.

Hai đặc điểm cơ bản của đa hình:

- Tại thời điểm chạy ứng dụng, các đối tượng của lớp con có thể được xử lý như là đối tượng của lớp cha. Nói cách khác, một đối tượng của lớp cha có thể giữ một đối tượng của lớp con và gọi phương thức của lớp con đó. Khi đó, kiểu dữ liệu của đối tượng lúc khai báo và lúc thực thi chương trình là khác nhau.
- Ở lớp cơ sở có thể cài đặt các phương thức ảo (virtual methods), ở các lớp dẫn xuất sẽ cài đặt các phương thức ghi đè (override methods). Khi chạy ứng dụng, trình điều khiển thực thi CLR (Common Language Runtime) sẽ gọi phương thức ghi đè của lớp con.

Cơ chế đa hình cho phép cài đặt một cách nhất quán các phương thức giống nhau của các đối tượng khác nhau thông qua hai bước cơ bản sau:

1. Tạo một lớp cơ sở chung của các loại đối tượng có liên quan với nhau. Sau đó cài đặt từng lớp dẫn xuất phù hợp với loại đối tượng cụ thể. 

Ví dụ, các hình vẽ khác nhau về hình dạng (vuông, tròn, tam giác,...) nên công thức tính diện tích cũng khác nhau. 

2. Ở lớp cơ sở

## Ghi đè phương thức (Method overriding)

Ví dụ ([Xem trên GitHub](https://github.com/nd-hung/oop/blob/main/docs/topics/inheritance/code/MethodOverriding/Program.cs)):

```c#
// Tạo lớp hình vẽ tổng quát (Shape)
public class Shape
{
    // Phương thức ảo tính diện tích
    // Shape không phải hình vẽ cụ thể, nên không tính được diện tích
    public virtual double Area()
    {
        return 0;
    }
}// Kết thúc lớp Shape

// Tạo lớp hình tròn (Circle) kế thừa lớp hình vẽ
public class Circle : Shape
{
    public double Radius;   // Thuộc tính lưu độ dài bán kính

    // Constructor
    public Circle(double r = 0)
    {
        Radius = r;
    }

    // Phương thức ghi đè (override) tính diện tích hình tròn
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}// Kết thúc lớp Circle

// Lớp hình chữ nhật (Rectangle) kế thừa lớp hình vẽ
public class Rectangle : Shape
{
    public double Width;    // Các thuộc tính lưu kích thước hình chữ nhật
    public double Height;

    // Constructor
    public Rectangle(double w = 0, double h = 0)
    {
        Width = w;
        Height = h;
    }

    // Phương thức ghi đè tính diện tích hình chữ nhật
    public override double Area()
    {
        return Width * Height;
    }
} // Kết thúc lớp Rectangle

// Chương trình chính
class Program
{
    public static void Main()
    {
        // Tạo đối tượng hình vẽ tổng quát
        Shape s0 = new Shape();
        // In kiểu đối tượng & diện tích
        Console.WriteLine("This is a {0}, area = {1:0.000}", s0.GetType(), s0.Area());

        // Khai báo đối tượng hình vẽ tổng quát và khởi tạo là hình tròn:
        Shape s1 = new Circle("Circle", 1); // Khởi tạo tên, bán kính
        // In kiểu đối tượng & diện tích
        Console.WriteLine("This is a {0}, area = {1:0.000}", s1.GetType(), s1.Area());

        // Khai báo đối tượng hình vẽ tổng quát và khởi tạo là hình chữ nhật:
        Shape s2 = new Rectangle("Rectangle", 3, 7); // Khởi tạo tên, các cạnh
        // In kiểu đối tượng & diện tích
        Console.WriteLine("This is a {0}, area = {1:0.000}", s2.GetType(), s2.Area());
    }
}

/* Output
This is a Shape, area = 0.000
This is a Circle, area = 3.142
This is a Rectangle, area = 21.000
*/
```




