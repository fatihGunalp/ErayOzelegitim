using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eray_OOP_Alistirma
{
    internal abstract class Kisi
    {
        private string ad { get; set; }
        private int yas { get; set; }

        public string Ad 
        { get { return ad; } 
          set { ad = value; } 
        }
        public int Yas 
        { get { return yas; } 
          set { yas = value; } 
        }

        public Kisi() 
        { 
        
        }
        public Kisi(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public abstract void Tanit();



    }
}
