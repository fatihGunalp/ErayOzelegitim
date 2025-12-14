using OOP_Interface.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Concretes
{
    internal class Audi : Otomobil,IHibrit,IYetenek
    {
        public override string Maxhiz()
        {
            return "Max hız 320km/h";
        }

        public string Otopilot()
        {
            throw new NotImplementedException();
        }
    }
}
