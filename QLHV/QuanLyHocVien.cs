using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    public class QuanLyHocVien
    {
        public List<HocVien> hvs = new List<HocVien>();
        public string NhapThongTin()
        {
            Console.Write("Nhap so luong hoc vien: ");
            int soLuongHocVien = Convert.ToInt32(Console.ReadLine());
            {
                for (int i = 0; i < soLuongHocVien; i++)
                {
                    HocVien hv = new HocVien();

                    Console.Write("Nhap mssv: ");
                    hv.mssv = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhap ho ten: ");
                    hv.hoten = Console.ReadLine();

                    Console.Write("Nhap que quan: ");
                    hv.quequan = Console.ReadLine();

                    Console.Write("Nhap diem 1: ");
                    hv.diem1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nhap diem 2: ");
                    hv.diem2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nhap diem 3 3: ");
                    hv.diem3 = Convert.ToDouble(Console.ReadLine());
                    hvs.Add(hv);
                }
            }
            return hvs.ToString();
        }
        public bool XacDinhDanhSachHocBong()
        {
            foreach (HocVien hv in hvs)
            {
                double tb = (hv.diem1 + hv.diem2 + hv.diem3) / 3;
                if (tb >= 8 && (hv.diem1 > 5 || hv.diem2 > 5 || hv.diem3 > 5))
                    return true;
            }
            return false;
        }
    }
}


