using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    public class HocVien
    {
        public int mssv { get; set; } 
        public string hoten { get; set; }
        public string quequan { get; set; }
        public double diem1 { get; set; }
        public double diem2 { get; set; }
        public double diem3 { get; set; }

        public HocVien(int mssv,string hoten,string quequan,double diem1,double diem2,double diem3)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.quequan = quequan;
            this.diem1 = diem1;
            this.diem2 = diem2;
            this.diem3 = diem3;
        }
        public HocVien()
        {

        }
    }
}
