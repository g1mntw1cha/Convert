using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    public class UAH
    {
        public static void USD()
        {
            Console.WriteLine("UAH — ?");
            int uax = Convert.ToInt32(Console.ReadLine());
            double sumx = 0.025 * uax;
            Console.WriteLine(sumx);
        }
    }
}
