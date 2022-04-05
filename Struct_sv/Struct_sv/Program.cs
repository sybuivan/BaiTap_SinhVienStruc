using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_sv
{
    class Program
    {
        

        struct SinhVien
        {
            public int MASO_248;
            public string HOTEN_248;
            public double DIEMC_248;
            public double DIEMJAVA_248;
            public double DIEMWEB_248;
        }

        enum thuocTinhSv_248
        {
            GIOITINH_248 = 0
        }
        static SinhVien NhapThongTinSinhVien_248(SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.MASO_248 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HOTEN_248 = Console.ReadLine();
            Console.Write(" Diem C: ");
            SV.DIEMC_248 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem JAVA: ");
            SV.DIEMJAVA_248 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem WEB: ");
            SV.DIEMWEB_248 = Double.Parse(Console.ReadLine());

            return SV;
        }
        static void XuatThongTinSinhVien_248(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MASO_248);
            Console.WriteLine(" Ho ten: " + SV.HOTEN_248);
            Console.WriteLine(" Diem C: " + SV.DIEMC_248);
            Console.WriteLine(" Diem JAVA: " + SV.DIEMJAVA_248);
            Console.WriteLine(" Diem WEB: " + SV.DIEMWEB_248);
        }

        static double DiemTBSinhVien_248(SinhVien SV)
        {
            return (SV.DIEMC_248 + SV.DIEMJAVA_248 + SV.DIEMWEB_248) / 3;
        }

        static void FindByName_248(SinhVien[] arr_sv_248, String keyword_248, int soLuong_248)
        {
            foreach (SinhVien sv in arr_sv_248)
            {
                if (String.Compare(sv.HOTEN_248, keyword_248) ==0)
                {
                    Console.WriteLine("Tim thay sinh vien: {0} ", sv.HOTEN_248);
                    Console.WriteLine("Diem tb sinh vien: {0}", DiemTBSinhVien_248(sv));
                    break;
                }
                else
                {
                    Console.WriteLine("Khong tim thay sinh vien: {0}", keyword_248);
                }

            }
        }

        static void Main(string[] args)
        {
            int soLuong_248, count = 1;

            Console.Write("Nhap bao nhieu sinh vien: ");
            soLuong_248 = int.Parse(Console.ReadLine());

            SinhVien[] arr_sv_248 = new SinhVien[soLuong_248];

            for(int i_248 = 0; i_248 < soLuong_248; i_248++)
            {
                SinhVien sv = new SinhVien();
                Console.WriteLine("\t Nhap sinh vien: {0}", (i_248));
                sv = NhapThongTinSinhVien_248(sv);
                arr_sv_248[i_248] = sv;
            }
           

            foreach (SinhVien sv in arr_sv_248)
            {

                Console.WriteLine("\t Thong tin sinh vien: {0}", (count));
                XuatThongTinSinhVien_248(sv);
                count++;
            }

            string ten_248;
            Console.WriteLine("\n\t Nhap ten sinh vien can tim:");
            ten_248 = Console.ReadLine();

            FindByName_248(arr_sv_248, ten_248, soLuong_248);
            Console.ReadKey();
        }
    }
}
