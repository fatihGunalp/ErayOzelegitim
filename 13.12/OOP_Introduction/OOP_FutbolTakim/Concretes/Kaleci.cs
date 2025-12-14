using OOP_FutbolTakim.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FutbolTakim.Concretes
{
    internal class Kaleci : Futbolcu,IKaleci
    {

        public Kaleci()
        {
            SutGuc = 50;
        }

        public Kaleci(int sutGuc, int pasGuc)
        {
            SutGuc = sutGuc;
            PasGuc = pasGuc;
        }

        public Kaleci(int sutGuc, int pasGuc, int kurtarmaGuc, int refleksguc)
        {
            SutGuc = sutGuc;
            PasGuc = pasGuc;
            KurtarmaGuc = kurtarmaGuc;
            RefleksGuc=refleksguc;
        }


        //Kurtarma Güç
        public int KurtarmaGuc { get; set; }

        //Refleks Güç
        public int RefleksGuc { get; set; }

        public string Degaj()
        {
            return Ad + " degaj yaptı";
        }

        public string Kurtar()
        {
            return Ad + " topu kurtardı";
        }
    }
}
