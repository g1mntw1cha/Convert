using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("USD to UAH == 1");
                Console.WriteLine("UAH to USD == 2");
                int why = Convert.ToInt32(Console.ReadLine());
                
                if(why == 1)
                {
                    usd.aboba();
                    break;
                }
                else if(why == 2)
                {
                    UAH.USD();
                    break;
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("спасибо за тестирование");
        }
    }
}
