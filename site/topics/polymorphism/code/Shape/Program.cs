/* Chương trình chính
Tạo 1 danh sách hình vẽ có cả hình tròn, hình chữ nhật.
- In ra danh sách hình vẽ & thông tin kèm theo
- Tìm hình vẽ có diện tích lớn nhất
- Đếm số lượng của mỗi loại hình vẽ
*/
class Program
{
    public static void Main()
    {
        const int MAX=100;
        // Nhập số lượng hình vẽ
        int n;
        do{
            Console.Write("Nhap so hinh ve: ");
            n = int.Parse(Console.ReadLine());
        }while(n <= 0 || n > MAX);

        // Tạo danh sách hình vẽ
        Shape[] hvList = new Shape[n];
        string choice;
        for(int i=0; i<n; i++)
        {
            do{
                Console.Write("Chon hinh ve: 1 - Circle, 2 - Rectangle");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1": 
                        hvList[i] = new Circle();
                        hvList[i].Nhap();
                        break;
                    case "2": 
                        hvList[i] = new Rectangle();
                        hvList[i].Nhap();                        
                        break;
                    default:
                        Console.WriteLine("Chon 1 hoac 2");
                        break;
                }
            }while()
        }
    }
}