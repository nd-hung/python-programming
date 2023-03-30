/* Minh họa kỹ thuật đa hình - Chương trình chính
*/
class Program
{
    public static void Main()
    {
        // Khai báo đối tượng hình vẽ tổng quát và khởi tạo là hình tròn:
        Shape s1 = new Circle("Circle", 1); // Khởi tạo tên, bán kính
        // In diện tích
        s1.Print();
        Console.WriteLine(s1.GetType());

        // Khai báo đối tượng hình vẽ tổng quát và khởi tạo là hình chữ nhật:
        Shape s2 = new Rectangle("Rectangle", 3, 7); // Khởi tạo tên, các cạnh
        // In diện tích
        s2.Print();
        Console.WriteLine(s2.GetType());

    }
}