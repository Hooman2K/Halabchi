using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalabchiCRM
{
    class Formula
    {
        public int Hefdah(int count)
        {
            double ghoti = (800 * 700 * 0.30 * 7.86 / 1000)/2;
            int result = Convert.ToInt32((count * ghoti) / 1000);
            return result;
        }
    }
}
