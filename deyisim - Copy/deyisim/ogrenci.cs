using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deyisim
{
    class ogrenci
    {
        public  string ad;
        public   string soyad;
        private string password;
        public string pass
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
            

    }
    
}
