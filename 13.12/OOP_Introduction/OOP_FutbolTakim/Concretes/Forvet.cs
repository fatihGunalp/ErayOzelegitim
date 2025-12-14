using OOP_FutbolTakim.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FutbolTakim.Concretes
{
    internal class Forvet : Futbolcu, IForvet
    {
        public string IleriKosu()
        {
            return Ad + " ileri koşu yapıyor";
        }
    }
}
