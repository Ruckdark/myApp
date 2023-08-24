using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhNangCao
{
    internal class Ngay1
    {
        //khai bao kieu liet ke "x"
        enum NhietDoNuoc
        {
            DoDong = 0,
            DoNguoi = 20,
            DoAm = 40,
            DoNong = 60,
            DoSoi = 100,
        }

        enum ThuTu
        {
            ChuNhat,
            ThuHai,
            ThuBa = 10,
            ThuTu,
        }
        static void Main(string[] args)
        {
            //// vd 1.
            //Console.WriteLine("Chao mung");
            //Console.Write("Cac ban");
            //Console.WriteLine();

            //string a;
            //a = Console.ReadLine();
            //Console.WriteLine(a);

            //int b;
            //b = Console.Read();
            //Console.WriteLine(b);

            ////vd 2.
            //int radius = 4;
            //const double PI = 3.14159;
            //double circum, area;
            //area = PI * radius * radius;
            //circum = 2 * PI * radius;
            //// in ket qua
            //Console.WriteLine("Ban kinh = {0}, PI = 1", radius, PI);
            //Console.WriteLine("Dien tich = {0}", area);
            //Console.WriteLine("Chu vi = {0}", circum);

            //vd 3*.
            //int x, y;
            //for (x = 0; x < 10; x++, Console.WriteLine("\n"));
            //for (y = 0; y < 10; y++, Console.WriteLine("{0}",y));

            ////bt
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.Write(" Ten ban la gi: ");
            //string name = Console.ReadLine();
            //Console.WriteLine(" Xin chao " + name);

            //"x":
            Console.WriteLine("Nhiet do dong: {0}", NhietDoNuoc.DoNong);
            Console.WriteLine("Nhiet do nguoi: {0}", NhietDoNuoc.DoNguoi);
            Console.WriteLine("Nhiet do am: " + NhietDoNuoc.DoAm);
            Console.WriteLine("etc..");


        }
    }
}
