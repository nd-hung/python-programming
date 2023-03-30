/* Minh họa kỹ thuật đa hình - Chương trình chính
*/
class Program
{
    public static void Main()
    {
        // Tạo đối tượng hình vẽ tổng quát
        Shape s0 = new Shape();
        // In diện tích
        Console.WriteLine("This is a {0}, area = {1:0.000}", s0.GetType(), s0.Area());

        // Khai báo đối tượng hình vẽ tổng quát và khởi tạo là hình tròn:
        Shape s1 = new Circle("Circle", 1); // Khởi tạo tên, bán kính
        // In diện tích
        Console.WriteLine("This is a {0}, area = {1:0.000}", s1.GetType(), s1.Area());

        // Khai báo đối tượng hình vẽ tổng quát và khởi tạo là hình chữ nhật:
        Shape s2 = new Rectangle("Rectangle", 3, 7); // Khởi tạo tên, các cạnh
        // In diện tích
        Console.WriteLine("This is a {0}, area = {1:0.000}", s2.GetType(), s2.Area());

    }
}