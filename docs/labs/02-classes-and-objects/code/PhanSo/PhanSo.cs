// Cài đặt lớp phân số

public class PhanSo
{
    // Khai báo các thuộc tính
    public int TuSo{get; set;}
    public int MauSo{get; set;}
    
    // Phương thức thiết lập
    public PhanSo(int ts=0, int ms=1)
    {
        TuSo = ts;
        if(ms != 0) MauSo = ms;
    }

    // Phương thức nhập phân số từ bàn phím
    public void Nhap()
    {
        Console.Write("Tu so = ");
        TuSo = int.Parse(Console.ReadLine());
        do{
        Console.Write("Mau so = ");
        MauSo = int.Parse(Console.ReadLine());
        }while(MauSo==0);
    }

    // Phương thức in phân số
    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", TuSo, MauSo);
    }
}