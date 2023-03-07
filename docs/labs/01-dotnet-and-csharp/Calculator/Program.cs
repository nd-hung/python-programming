﻿/*
Viết chương trình nhập từ bàn phím hai số nguyên a, b và một ký tự ch.
Nếu:
- ch là "+" thì thực hiện phép tính a + b và in kết quả lên màn hình.
- ch là "–" thì thực hiện phép tính a - b và in kết quả lên màn hình.
- ch là "*" thì thực hiện phép tính a * b và in kết quả lên màn hình.
- ch là "/" thì thực hiện phép tính a / b và in kết quả lên màn hình. Lưu ý kiểm tra điều kiện của phép chia.
*/

namespace Calculator
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Nhap a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            int b = Int32.Parse(Console.ReadLine());
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
