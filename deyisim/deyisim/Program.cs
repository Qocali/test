using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deyisim
{
    
    class Program
    {
        static void Main(string[] args)
        {

            ogrenci ogrenci = new ogrenci
            {
                ad="qocali",
                soyad="babayev",
                pass="qocu123"
            };
                
            
            Console.WriteLine(ogrenci.pass);
            //string ad = "QOCALI BABAYEV";
            //string ad1 = ad.Remove(6,8);
            //Console.WriteLine(ad1);
            //Console.ReadLine();




        }
        
        
            
    }
}
