using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deyisim
{
    class Class1
    {
        public static string sozdeyis;
        public static string sozler()
        {

            Console.WriteLine("sozu giriniz:");
            string soz = Console.ReadLine();
            for (int i = 0; i <soz.Length ; i++)
            {

                if (i < (soz.Length - 1))
                {
                    sozdeyis = (soz.Substring(i, 1) + "*");
                    Console.Write(sozdeyis);
                }
                else
                {
                    sozdeyis= soz.Substring(i, 1);
                    
                }
            }
            return sozdeyis;
        }
    }
}
