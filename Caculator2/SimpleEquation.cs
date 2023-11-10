using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator2
{
    public class SimpleEquation
    {
        double a, b;
        public SimpleEquation(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public string SingleEquation()
        {
            double e;
            string rs;
            if (a == 0)
                if (b == 0)
                    rs = "VSN";
                else
                    rs = "VN";
            else
            {
                e = -b / a;
                rs = e.ToString();
            }
                
            return rs;

        }
    }
}
