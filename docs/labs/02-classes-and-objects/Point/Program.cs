// Cài đặt lớp Point
public class Point
{
    // Khai báo thuộc tính (X, Y) là tọa độ điểm trong mặt phẳng
    public double X { get; set; }
    public double Y { get; set; }

    // Hàm thiết lập
    public Point(double x = 0, double y = 0)
    {
        X = x; Y = y;
    }

    // Phương thức nhập
    public void Nhap()
    {
        Console.Write("Nhap hoanh do X");
        X = double.Parse(Console.ReadLine());
        Console.Write("Nhap tung do do Y");
        Y = double.Parse(Console.ReadLine());
    }

    // Phương thức xuất
    public void Xuat()
    {
        Console.WriteLine("({0},{1})", X, Y);
    }

    // Phương thức di chuyển
    public void Move(double dx=0, double dy=0)
    {
        X += dx;
        Y += dy;
    }

}

// Chương trình chính
class Program
{
    public static void Main()
    {
        Point p1 = new Point(5, 8);
        p1.Xuat();
        // Thay đổi vị trí của điểm p1
        p1.Move(1,2);
        // In ra vị trí sau khi di chuyển
        p1.Xuat();
    }
}