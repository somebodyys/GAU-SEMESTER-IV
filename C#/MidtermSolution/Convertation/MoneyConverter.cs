using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertation
{
    public class MoneyConverter
    {

        private static decimal usd_rate = 3.41M;
        private static decimal euro_rate = 4.2M;
    
        public static decimal MoneyConvert(decimal money, string to)
        {
            if (to.Equals("usd")) return money / usd_rate;
            if (to.Equals("eur")) return money / euro_rate;
            throw new ArgumentException("Unknown Currecy!");
        }
    }
}
