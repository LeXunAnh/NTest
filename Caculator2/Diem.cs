using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator2
{
    public class Diem
    {
        private double x;
        private double y;

        // Phương thức khởi tạo
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Phương thức lấy hoành độ
        public double getX()
        {
            return x;
        }

        // Phương thức lấy tung độ
        public double getY()
        {
            return y;
        }
    }
}
