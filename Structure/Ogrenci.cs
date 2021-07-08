namespace Structure
{
    public struct Ogrenci//value type
    {
        //new ile bir öğrenci nesnesi tanımladığında ilk çalışacak yer burası
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet=true)
        {
            
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        //set:deger atama ogr.Numara=10(dışarıdan değer alma) get:içerdeki değeri okumayı sağlar   (kapsülleme)
        public int Numara { get; set; }//property
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }


        // Geçersiz Kılmak/ Ezmek / Override
        public override string ToString()
        {
            //sayılar hizalandırmaya yarar
            return $"{Numara,-5}" +
                $"{Adi,-10} {Soyadi,-10}"
                + string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}
