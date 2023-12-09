using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator2
{
    public class HinhChuNhat
    {
        private Diem topLeft;
        private Diem bottomRight;

        // Phương thức khởi tạo
        public HinhChuNhat(Diem topLeft, Diem bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        // Phương thức tính diện tích hình chữ nhật
        public double DienTich()
        {
            // Diện tích = chiều dài * chiều rộng
            double chieuDai = Math.Abs(topLeft.getX() - bottomRight.getX());
            double chieuRong = Math.Abs(topLeft.getY() - bottomRight.getY());
            return chieuDai * chieuRong;
        }

        // Phương thức kiểm tra hai hình chữ nhật có giao nhau hay không
        public bool GiaoNhau(HinhChuNhat hcn)
        {
            if (topLeft.getX() > hcn.bottomRight.getX() || hcn.topLeft.getX() > bottomRight.getX())
            {
                return false;
            }

            if (topLeft.getY() < hcn.bottomRight.getY() || hcn.topLeft.getY() < bottomRight.getY())
            {
                return false;
            }
            return true;
        }
    }
}
