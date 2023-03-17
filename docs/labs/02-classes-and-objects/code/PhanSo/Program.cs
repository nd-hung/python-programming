// Chương trình chính

class Program
{
    static void Main()
    {
        // Tạo phân số bằng cách gọi phương thức thiết lập
        PhanSo ps1 = new PhanSo(1,2);
        // In phân số
        ps1.Xuat();
        // Tạo phân số bằng cách gọi phương thức nhập
        PhanSo ps2 = new PhanSo();
        ps2.Nhap();
        // In phân số
        ps2.Xuat();
    }
}