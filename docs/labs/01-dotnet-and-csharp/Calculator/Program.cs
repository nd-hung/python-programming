namespace Calculator
{
    internal class Program
    {
        public static void Main()
        {
            int a, b;
            Console.Write("Nhap a = ");
            string st = Console.ReadLine();
            if(st is null) st="0";
            a = int.Parse(Con)
            Console.Write("Nhap b = ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap ky hieu phep toan (+,-,*,/) = ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+": Console.WriteLine("{0} + {1} = {2}", a, b, a + b); break;
                case "-": Console.WriteLine("{0} - {1} = {2}", a, b, a - b); break;
                case "*": Console.WriteLine("{0} * {1} = {2}", a, b, a * b); break;
                case "/":
                    if (b == 0)
                        Console.WriteLine("Khong chia duoc!");
                    else
                        Console.WriteLine("{0}/{1} = {2}", a, b, (double)a / b);
                    break;
                default: Console.WriteLine("Khong biet phep toan!"); break;
            }
        }
    }
}
