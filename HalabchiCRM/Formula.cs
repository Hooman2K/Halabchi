using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalabchiCRM
{
    class Formula
    {
        public double Hefdah885(double count)
        {
            //خروجی تابع کیلوگرم است
            //بزرگی عدد 2 میلیارد
            double badane = Math.Truncate((885 * 700 * 0.30 * 7.86 / 1000) / 2);

            double sar = ((800 * 800 * 0.28 * 7.86) / 1000) / 9;
            double kaf = ((790 * 790 * 0.28 * 7.86) / 1000) / 9;

            double halab17 = badane + sar + kaf;

            double result = Math.Floor((count * halab17) / 1000);
            //double result = Math.Ceiling((count * halab17) / 1000);
            return result;
        }
    }
}
