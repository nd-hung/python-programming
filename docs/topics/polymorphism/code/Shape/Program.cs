// Chương trình chính

class Program
{
    public static void Main()
    {
        // Tạo đối tượng hình vẽ là hình tròn
        Shape s1 = new Circle("Circle", 1);
        // Tạo đối tượng hình vẽ là hình chữ nhật
        Shape s2 = new Rectangle("Rectangle", 3,7);
        // In thông tin các đối tượng
        s1.Print();
        s2.Print();


    }
}