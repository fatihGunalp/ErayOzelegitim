

namespace OOP_Introduction
{
    internal class Bilgisayar
    {
        //Bir bilgisayarın ...'sı olur.
        //EkranKartı
        //Anakartı
        //Islemci


        //field: alan
        //field varsayılan erişim belirteci private

        //public: umumi, açık her yerden ulaşılır.
        //internal: sadece ait olduğu olduğu projeden ulaşılır.
        //protected: sadece miras alınan class içinden ulaşılır.
        //protected internal: sadece ait olduğu projede ve miras alınan class'dan ulaşılır.



        //oluşturulan bütün bilgisayarların anakart markası "asus" olsun. Eğer bu değer harici bir değer gönderilirse kullanıcıya "yanlış marka" mesajı iletilsin.

        #region Encapsulation
        string _anakartMarka;

        public string AnaKartMarka
        {

            get { return _anakartMarka; }

            set
            {
                if (value == "asus")
                {
                    _anakartMarka = value;
                }
                else
                {
                    _anakartMarka = "tanımsız marka";
                }
            }
        } 
        #endregion




        public string EkranKartMarka { get; set; }
        public string IslemciMarka { get; set; }












    }
}
