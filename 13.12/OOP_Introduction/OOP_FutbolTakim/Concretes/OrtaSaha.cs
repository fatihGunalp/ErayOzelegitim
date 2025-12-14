using OOP_FutbolTakim.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FutbolTakim.Concretes
{
    internal class OrtaSaha : Futbolcu, IOrtaSaha
    {
        public string OyunKur()
        {
            return Ad + " oyun kuruyor";
        }
    }
}
