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
        public static List<MATHANG>  NhapDSMatHang()
        {
            int n;
           List<MATHANG> kq;
            Console.WriteLine(" Nhap vao so luong Mat Hang");
            n = int.Parse(Console.ReadLine());

            kq = new List<MATHANG>(n);
            for (int i =0; i <n; i++)
            {
                Console.WriteLine($"Nhap mat hang thư {i+1}");
              kq.Add(Nhapmathang());
            }
            return kq;
        }
        public static string XuatMatHang(MATHANG a)
        {
            
         return  $"Mahang :{a.Mahang} Tenhang:{ a.Tenhang}/ Handung:{ a.Handung}/ Cong ty san xuat: { a.Congtysanxuat}/ Nam San xuat: { a.Namsanxuat}/Loaihang: { a.Loaihang}";
         
        }
        public static string XuatDSMatHang(List<MATHANG> DSmahang)

        {
           
            string s = string.Empty;
            for (int i=0;i<DSmahang.Count;i++)
            {
            s = $"mat hang thu {i}  : " + XuatMatHang(DSmahang[i])+"\n" +s  ;
            }
            return "Danh sach mat hang dang có\n"+ s;
            
        }
        public static  List<MATHANG>  ThemMatHang(List<MATHANG>  DSMatHang)
        {
           
            MATHANG A;
            A = Nhapmathang();
            DSMatHang.Insert(0,A);
            Console.WriteLine("Danh sach da duoc them");
          
            return DSMatHang;
        }
        public static List<MATHANG> XoaMatHang(List<MATHANG> DSMatHang )
        {
            int i;
            Console.WriteLine(" Nhap vao vi tri can xoa");
            i = int.Parse(Console.ReadLine());
            DSMatHang.RemoveAt(i);
            return DSMatHang;
        }
        static void Main(string[] args)
        {
            int k;
            string s = string.Empty;
            //  MATHANG mh;
            // mh = Nhapmathang();
            //  XuatMatHang(mh);
            // Console.ReadKey();
            List<MATHANG> mathang;
            mathang = NhapDSMatHang();
            Console.Clear();
            s= XuatDSMatHang(mathang);
            Console.WriteLine(s);
            Menu:
            Console.WriteLine("Phan Mem quan ly cua hang");
            Console.WriteLine(" 1.Them mat hang");
            Console.WriteLine(" 2.Xoa mat hang");
            Console.WriteLine(" 3.Sua mat hang");
            Console.WriteLine(" 4.Tim kiem  mat hang");
            Console.WriteLine(" 5.Ket thuc chuong trinh");
            Console.WriteLine(" Hay nhap menu can su dung  1 ,2 ,3 ,4,5");
            k =int.Parse(Console.ReadLine());

            switch (k)
             {
                case 1:
                    string x = string.Empty;
                    Console.WriteLine($" Them mat hang ");
                    ThemMatHang(mathang);
                    Console.Clear();
                   x= XuatDSMatHang(mathang);
                    Console.WriteLine(x);
                 goto Menu;
                                        
                case 2:
                   
                    Console.WriteLine(" Xoa mat hang");
                    XoaMatHang(mathang);
                    x = XuatDSMatHang(mathang);
                    Console.WriteLine(x);
                    goto Menu;
                case 3:
                    Console.WriteLine(" Sua mat hang");
                    break;
                case 4:
                    Console.WriteLine(" Tim kiem  mat hang");
                    break;
                case 5:
                    Console.WriteLine(" Ket thuc chuong trinh");
                    break;


            }
            Console.ReadKey();

        }
    }
}
