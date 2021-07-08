using System;
using System.Collections.Generic;


namespace Structure
{
    public class Program//referance type
    {
        static void Main(string[] args)
        {
            //struct
            Ogrenci ogr = new Ogrenci();
            ogr.Numara = 10;
            ogr.Adi = "Ahmet";
            ogr.Soyadi = "Yılmaz";
            ogr.Cinsiyet = true;


            //alternatif kullanma
            var ogr2 = new Ogrenci()
            {
                Numara = 20,
                Adi = "Fatma",
                Soyadi = "Dag",
                Cinsiyet = false
            };

            //alternatif kullanma
            var ogr3 = new Ogrenci(30, "Mehmet", "Avcı", true);//constructor oluşturduğumuz için bu şekilde kullanabilirz
            var ogr4 = new Ogrenci(40, "Asaf", "Karlıdağ");//true default değerden gelecek

            Console.WriteLine(ogr);
            Console.WriteLine(ogr2);
            Console.WriteLine(ogr3);
            Console.WriteLine(ogr4);

            Console.WriteLine();
            Console.WriteLine("List Çıktıları");
            //list kullanımı
            var ogrenciListesi = new List<Ogrenci>()
            {
            new Ogrenci(50,"Mehmet","Ali",true),
            new Ogrenci(60, "Ali", "Mutlu", true),
            new Ogrenci(70,"Fatma","Seven",false)
            };

            ogrenciListesi.ForEach(item=>Console.WriteLine(item));
            
        }
    }
}
