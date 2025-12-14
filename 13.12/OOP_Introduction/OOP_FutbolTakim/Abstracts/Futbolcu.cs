namespace OOP_FutbolTakim.Abstracts
{
    internal abstract class Futbolcu
    {
        protected Futbolcu()
        {
            SutGuc = 50;
            PasGuc = 50;
        }
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FormaNo { get; set; }

        //ŞutGüc
        public int SutGuc { get; set; }

        //PasGüc
        public int PasGuc { get; set; }
    }
}
