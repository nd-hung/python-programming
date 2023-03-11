/*
Minh họa kỹ thuật thừa kế
Xây dựng lớp Rectangle quản lý hình chữ nhật.
Xây dựng lớp Square quản lý hình vuông.
*/

// Cài đặt lớp Rectangle
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    // Hàm thiết lập có tham số
    public Rectangle(double w = 0, double h = 0)
    {
        Width = w;
        Height = h;
    }
    // Hàm trả về diện tích hình chữ nhật
    public double Area()
    {
        return Width*Height;
    }
}

// Xây dựng lớp Square kế thừa lớp Rectangle
public class Square: Rectangle
{
    // Hàm thiết lập
    public Square(double w=0):base(w,w)
    {
    }
}

// Chương trình chính
class Program
{
    static void Main()
    {
        // Tạo đối tượng hình vuông
        Square s1 = new Square(5);
        
        // Tính & in diện tích hình vuông
        double area = s1.Area();
        Console.WriteLine("Dien tich hinh vuong = {0}", area);
    }
}
