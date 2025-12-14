namespace OOP_Interface.Abstracts
{
    internal abstract class Otomobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        //Metotlar
        public abstract string Maxhiz();
    }
}
