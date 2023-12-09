using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    class Program
    {
        static void Main()
        {
            QuanLyHocVien qlhv = new QuanLyHocVien();
            qlhv.NhapThongTin();
            qlhv.XacDinhDanhSachHocBong();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
