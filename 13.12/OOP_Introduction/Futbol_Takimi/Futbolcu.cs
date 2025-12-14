using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Takimi
{
    internal class Futbolcu:Takim,ISut,IPas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Mevki { get; set; }

        public int FormaNo { get; set; }

        public string PasGucu(string pas)
        {
            return pas; 
        }

        public string PasGucu()
        {
            return "Pas atmalı";
        }

        public string SutGucu()
        {
            return "Sut Atmali";
        }

        public string SutGucu(string sut)
        {
            return sut;
        }
    }
}
