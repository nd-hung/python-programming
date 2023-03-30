// Minh họa cơ chế đa hình

// Tạo lớp hình vẽ tổng quát (Shape)
public class Shape
{
    protected string Name; // Thuộc tính lưu tên hình vẽ

    // Constructor
    public Shape(string name = "")
    {
        Name = name;
    }

    // Phương thức ảo tính diện tích
    public virtual double Area()
    {
        return 0;
    }
    public virtual void Print() { }
}

// Tạo lớp hình tròn (Circle) kế thừa lớp hình vẽ
public class Circle : Shape
{
    public double Radius;   // Thuộc tính lưu độ dài bán kính

    // Constructor
    public Circle(string name = "", double r = 0) : base(name)
    {
        Radius = r;
    }

    // Phương thức ghi đè (override) tính diện tích hình tròn
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    // Phương thức ghi đè in thông tin hình tròn
    public override void Print()
    {
        Console.WriteLine("This is a {0}, area = {1:.000}", Name, Area());
    }
}

// Lớp hình chữ nhật (Rectangle) kế thừa lớp hình vẽ
public class Rectangle : Shape
{
    public double Width;    // Các thuộc tính lưu kích thước hình chữ nhật
    public double Height;

    // Constructor
    public Rectangle(string name = "", double w = 0, double h = 0) : base(name)
    {
        Width = w;
        Height = h;
    }

    // Phương thức ghi đè tính diện tích hình chữ nhật
    public override double Area()
    {
        return Width * Height;
    }

    // Phương thức ghi đè in thông tin hình chữ nhật
    public override void Print()
    {
        Console.WriteLine("This is a {0}, area = {1:.000}", Name, Area());
    }
}