using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhNangCao
{
    internal class BaiTapNgay2
    {
        // Bài 1: Viết chương trình nhập vào đơn giá 1 mặt hàng và số lượng bán của mặt hàng.
        // Tính tiền khách phải trả, với thông tin như sau:
        /*
          * Thành tiền: đơn giá * số lượng.
          * Giảm giá: nếu thành tiền>100 thì giảm 3% thành tiền, ngược lại không giảm.
          * Tổng tiền phải trả: Thành tiền - giảm giá.
         */


        // Bài 2: Viết chương trình tính tiền điện sử dụng trong tháng:
        /*
         * Từ 1 - 100kw: 5$
         * Từ 101 - 150kw: 7$
         * Từ 151 - 200kw: 15$
         * Từ 201 - 300kw: 15$
         * từ 300kw trở lên 20$
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //// Bài 1:
            //float donGia, thanhTien, giamGia, tongTienPhaiTra;
            //int soLuongBan;

            //Console.Write(" Nhap vao don gia cua mat hang: ");
            //donGia = Convert.ToInt32(Console.ReadLine());
            //Console.Write(" Nhap so luong ban cua mat hang: ");
            //soLuongBan = Convert.ToInt32(Console.ReadLine());

            //thanhTien = donGia * soLuongBan;
            //giamGia = (thanhTien > 100) ? (thanhTien * 0.03f) : 0;
            //tongTienPhaiTra = thanhTien - giamGia;
            //Console.WriteLine(" Thanh tien: " + thanhTien + "\n So tien duoc giam: " + giamGia +  "\n Tong tien phai tra la: " + tongTienPhaiTra);

            //// Bài 2:
            //int soDien;
            //float donGia, soTienPhaiTra = 0;
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.Write(" Nhập số điện tiêu thụ trong tháng: ");
            //soDien = Convert.ToInt32(Console.ReadLine());
            ///*
            // * Từ 1 - 100kw: 5$
            // * Từ 101 - 150kw: 7$
            // * Từ 151 - 200kw: 15$
            // * Từ 201 - 300kw: 15$
            // * từ 300kw trở lên 20$
            // */
            //if (soDien <= 100)
            //{
            //    soTienPhaiTra = soDien * 5;
            //}
            //else if (soDien > 100 && soDien <= 150)
            //{
            //    soTienPhaiTra = (100 * 5) + (soDien - 100) * 7;
            //}
            //else if (soDien > 150 && soDien <= 200)
            //{
            //    soTienPhaiTra = (100 * 5) + (50 * 7) + (soDien - 150) * 15;
            //}
            //else if (soDien > 200 && soDien <= 300)
            //{
            //    soTienPhaiTra = (100 * 5) + (50 * 7) + (50 * 15) + (soDien - 200) * 15;
            //}
            //else
            //    soTienPhaiTra = (100 * 5) + (50 * 7) + (50 * 15) + (100 * 15) + (soDien - 300) * 20;
            //Console.WriteLine(" Số tiền điện phải trả là: " + soTienPhaiTra);

            //// Bài 3: Kiểm tra lại
            //int n;
            //double tong = 0, mau = 0, tu = 0;

            //do
            //{
            //    Console.Write(" Nhập n = ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //} while (n <= 0);

            //for (int i = 1; i <= n; i++)
            //{
            //    tu = Math.Pow(-1, n + 1);
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    mau += Math.Pow(i,2);
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    tong += (tu / mau);
            //}
            //Console.WriteLine(" S = " + tong);

            // Bài 4: Kiểm tra lại
            int x, n;
            double S = 0;

            Console.Write(" Nhập x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhập n = ");
            n = Convert.ToInt32(Console.ReadLine());

            int giaiThua(int m)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * giaiThua(n - 1);
                }
            }

            for (int i = 1; i <= n; i++)
            {
                S += Math.Pow(x, i) / giaiThua(i);
            }

            Console.WriteLine(" S({0},{1}) = {2}", x, n, S);
        }
    }
}
