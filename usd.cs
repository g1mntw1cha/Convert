using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    public class usd
    {
        public static void aboba()
        {
            Console.WriteLine("USD — ?");
            int usx = Convert.ToInt32(Console.ReadLine());
            double sum = 39.50 * usx;
            Console.WriteLine("UAH: {0}", sum);
        }
    }
}
