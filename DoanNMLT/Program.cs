using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanNMLT
{
   
    class Program
    {
        public struct MATHANG
        {
            public string Mahang;
            public string Tenhang;
            public int Handung;
            public string Congtysanxuat;
            public int Namsanxuat;
            public string Loaihang;

        }
        public static MATHANG Nhapmathang()
        {
            MATHANG kq;
            Console.WriteLine("Nhap vao Mahang");
            kq.Mahang = Console.ReadLine();
            Console.WriteLine("Nhap vao Tenhang");
            kq.Tenhang = Console.ReadLine();
            Console.WriteLine("Nhap vao Handung");
            kq.Handung =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao Cong Ty san Xuat");
            kq.Congtysanxuat = Console.ReadLine();
            Console.WriteLine("Nhap vao Nam San Xuat");
            kq.Namsanxuat =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao Loai Hang");
            kq.Loaihang = Console.ReadLine();
            return kq;
        }
        public static MATHANG [] NhapDSMatHang()
        {
            int n;
           MATHANG [] kq;
            Console.WriteLine(" Nhap vao so luong Mat Hang");
            n = int.Parse(Console.ReadLine());

            kq = new MATHANG[n];
            for (int i =0; i <kq.Length; i++)
            {
                Console.WriteLine($"Nhap mat hang thư {i+1}");
              kq[i]=  Nhapmathang();
            }
            return kq;
        }
        public static string XuatMatHang(MATHANG a)
        {
            
         return  $"Mahang :{a.Mahang} Tenhang:{ a.Tenhang}/ Handung:{ a.Handung}/ Cong ty san xuat: { a.Congtysanxuat}/ Nam San xuat: { a.Namsanxuat}/Loaihang: { a.Loaihang}";
         
        }
        public static string XuatDSMatHang(MATHANG [] DSmahang)

        {
           
            string s = string.Empty;
            for (int i=0;i<DSmahang.Length;i++)
            {
            s = $"mat hang thu {i}  : " + XuatMatHang(DSmahang[i])+"\n" +s  ;
            }
            return "Danh sach mat hang dang có\n"+ s;
            
        }
        static void Main(string[] args)
        {
            int k ;
            string s =string.Empty;
          //  MATHANG mh;
           // mh = Nhapmathang();
          //  XuatMatHang(mh);
           // Console.ReadKey();
            MATHANG[] mathang;
            mathang= NhapDSMatHang();
            Console.Clear();
           s= XuatDSMatHang(mathang);
            Console.WriteLine(s);
            Console.WriteLine("Phan Mem quan ly cua hang");
            Console.WriteLine(" 1.Them mat hang");
            Console.WriteLine(" 2.Xoa mat hang");
            Console.WriteLine(" 3.Sua mat hang");
            Console.WriteLine(" 4.Tim kiem  mat hang");
            Console.WriteLine(" Hay nhap menu can su dung  1 ,2 ,3 ,4");
            k =int.Parse(Console.ReadLine());

            switch (k)
             {
                case 1:
                    Console.WriteLine(" Them mat hang");
                    break;
                case 2:
                    Console.WriteLine(" Xoa mat hang");
                    break;
                case 3:
                    Console.WriteLine(" Sua mat hang");
                    break;
                case 4:
                    Console.WriteLine(" Tim kiem  mat hang");
                    break;


            }
            Console.ReadKey();

        }
    }
}
