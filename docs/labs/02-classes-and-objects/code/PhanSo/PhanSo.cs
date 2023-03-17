// Cài đặt lớp phân số

public class PhanSo
{
    // Khai báo các thuộc tính
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    // Phương thức thiết lập
    public PhanSo(int ts = 0, int ms = 1)
    {
        TuSo = ts;
        if (ms != 0) MauSo = ms;
    }

    // Phương thức nhập phân số từ bàn phím
    public void Nhap()
    {
        Console.Write("Tu so = ");
        TuSo = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Mau so = ");
            MauSo = int.Parse(Console.ReadLine());
        } while (MauSo == 0);
    }

    // Phương thức in phân số
    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", TuSo, MauSo);
    }

    // Phương thức tối giản phân số
    public void ToiGian()
    {
        // Tìm UCLN của tử số và mẫu số
        int ucln = MyMath.UCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;
    }
}

// Lớp chứa thư viện các hàm toán học tự định nghĩa (lớp tĩnh)
public static class MyMath
{
    // Phương thức tìm UCLN của 2 số nguyên dương (phương thức tĩnh)
    public static int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        int min = (a > b) ? b : a;
        int ucln = 1;
        for (int i = min; i >= 1; i--)
            if (a % i == 0 && b % i == 0)
            {
                ucln = i;
                break;
            }
        return ucln;
    }
}