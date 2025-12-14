using OOP_Interface.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Concretes
{
    internal class Tesla : Otomobil, IYetenek, IElektrik
    {
        public override string Maxhiz()
        {
            return "Max 220km/h";
        }

        public string Otopilot()
        {
            return "otopilot aktif";
        }
    }
}
