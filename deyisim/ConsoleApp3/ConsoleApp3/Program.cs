using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Baslangic reqemi daxil edin : ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sonuncu reqemi daxil edin : ");
            int z = Convert.ToInt32(Console.ReadLine());

            int b = 0;
            int d = 0;
            for (int i = k; i <= z; i++)
            {
                if (i > 0)
                {
                    if (i % 3 == 0 && i % 4 == 0)
                    {
                        b += i;
                        d++;
                        b *= i;
                    }
                }
            }



            if (d == 0)
            {
                Console.WriteLine("Bu araliqda 3 ve 4'e bolunen eded yoxdur !!!");
            }

            else
            {
                double l = b / d;
                Console.WriteLine(l);
            }
        }
    }
}
