/* Minh họa lớp và đối tượng
Xử lý hình tròn
*/

namespace CircleProject
{
    // Cài đặt lớp hình tròn
    class HinhTron
    {
        public double X{get; set;}  // Hoành độ tâm
        public double Y{get; set;}  // Tung độ tâm
        private double banKinh; // Trường (field)
        public double BanKinh{
            get{return banKinh;}
            set{
                // Nếu giá trị >= 0 mới thực hiện lệnh gán giá trị
                if(value>=0) banKinh = value;
            }
        }   

        // Hàm thiết lập
        public HinhTron(double x=0, double y=0, double r=0)
        {
            X = x;
            Y = y;
            banKinh = r;
        }

        // Hàm in thông tin hình tròn
        public void Xuat()
        {
            Console.WriteLine("Toa do tam: ({0},{1}), ban kinh = {2}\n", X, Y, banKinh);
        }
    }

    // Chương trình chính
    class Program
    {
        public static void Main()
        {
            // Tạo 1 hình tròn
            HinhTron c1 = new HinhTron(1,2,3);
            // In thông tin hình tròn
            c1.Xuat();
        }
    }
}