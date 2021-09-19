using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isnull
{
    class Program
    {
        static void Main(string[] args)
        {
            sad a = new sad();
            sad b = new over();
            Console.WriteLine(a.salam(7));
            Console.WriteLine(b.salam(5));
            
            Console.ReadLine();
        }
    }
}
