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

    // Phương thức tính khoảng cách đến gốc tọa độ
    public double Distance()
    {
        return Math.Sqrt(X*X+Y*Y);
    }

}

// Lớp PointList quản lý danh sách điểm
public class PointList
{
    // Khai báo các thuộc tính
    public int SoLuong;
    public Point[] DS; 

    // Phương thức nhập danh sách điểm
    public void Nhap()
    {
        do{
            Console.Write("Nhap so diem: ");
            SoLuong = int.Parse(Console.ReadLine());
        }while(SoLuong <= 0);

        DS = new Point[SoLuong];
        for(int i=0; i< SoLuong; i++)
        {
            DS[i] = new Point();
            Console.Write("Nhap toa do diem thu {0}:", i+1);
            DS[i].Nhap();
        }
    }

    // Phương thức xuat danh sách điểm
    public void Xuat()
    {
        for(int i=0; i< SoLuong; i++)
        {
            Console.Write("Toa toa do diem thu {0}:", i+1);
            DS[i].Xuat();
        }
    }

    // Tìm điểm gần gốc tọa độ nhất
    public void DiemGanNhat()
    {
        double min = DS[0].Distance();
        int minIndex = 0;
        for(int i=1; i<SoLuong; i++)
        if(DS[i].Distance() < min)
        {
            min = DS[i].Distance();
            minIndex = i;
        }
        Console.WriteLine("Diem gan nhat la: ");
        DS[minIndex].Xuat();
    }

}

// Chương trình chính
class Program
{
    public static void Main()
    {
        PointList pl = new PointList();
        pl.Nhap();
        pl.Xuat();
        pl.DiemGanNhat();
    }
}