using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator2
{
    public class Power
    {
        public static double Power1(double x,int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return x * Power1(x, n - 1);
            else
                return Power1(x, n + 1) / x;
        }
    }
    
}
