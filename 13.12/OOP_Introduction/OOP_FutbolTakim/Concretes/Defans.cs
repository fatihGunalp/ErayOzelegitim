using OOP_FutbolTakim.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FutbolTakim.Concretes
{
    internal class Defans : Futbolcu,IDefans
    {
        //Press Güç
        public int PressGuc { get; set; }

        public string PresYap()
        {
            return Ad + " pres yapıyor";
        }
    }
}
