using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Hayvan
    {
        public string Renk { get; set; }
        public string Tur { get; set; }


        //virtual: bir metodun/özellik isteğe bağlı ezilebilir olmasını sağlar
        public virtual string Sescikar()
        {
            return "tanımlı hayvan sesi";
        }
    }
}
