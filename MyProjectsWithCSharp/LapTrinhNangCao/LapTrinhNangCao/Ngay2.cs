using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhNangCao
{
    internal class Ngay2
    {
        static void Main(string[] args)
        {
            int a, b;
            char pt;
            Console.Write(" Nhap a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap phep toan can thuc hien:");
            pt = Console.ReadKey(false).KeyChar;
            Console.WriteLine(" Ket qua la: " + Tinh(a,b,pt));
            //Console.ReadLine();
        }

        private static string Tinh(int a, int b, char pt)
        {
            switch (pt)
            {
                case '+': return " a + b = " + (a + b);
                case '-': return " a - b = " + (a - b);
                case '*': return " a * b = " + (a * b);
                case '/': if (b != 0) return " a / b = " + ((float)a / b);
                    else return " b = 0";
                default: return " Nhap sai phep toan ";
            }
        }
    }
}
