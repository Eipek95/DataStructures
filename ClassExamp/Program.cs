using System;
using System.Collections.Generic;

namespace ClassExamp
{
    class Program
    {
        static void Main(string[] args)
        { 
            OgretimElemani ogrGor = new OgretimElemani()
            {
                SicilNo=102,
                Adi="Deniz",
                Soyadi="Yılmaz",
                Cinsiyet=true
            };
            Console.WriteLine(ogrGor);
            
            ogrGor.SicilNo = 101;
            ogrGor.Adi = "Ahmet";
            ogrGor.Soyadi = "Yalçın";
            ogrGor.Cinsiyet = true;
            Console.WriteLine(ogrGor);
           
            OgretimElemani ogretimElemani = new OgretimElemani(103,"İbrahim","Hakan",true);
            Console.WriteLine(ogretimElemani);




            //class reference type
            var liste1 = new List<OgretimElemani>() 
            {
               new OgretimElemani(104,"Hakan","Sakan",true),
               new OgretimElemani(105,"Elif","Tunç",false),
               new OgretimElemani(106,"Meltem","Yılmaz",true),
               new OgretimElemani(107,"Leyla","Polat",false)
            };
            #region
            Console.WriteLine("Liste1");
            liste1.ForEach(ogrEle => Console.WriteLine(ogrEle));
            Console.WriteLine();

            Console.WriteLine("Liste2");
            var liste2 = liste1;
            liste2.ForEach(ogrEle => Console.WriteLine(ogrEle));
            #endregion


            liste2.Add(new OgretimElemani(108, "Eleman", "Yeni", false));
            liste1.RemoveAt(0);
            Console.WriteLine("Liste2 -> Ekleme Yapıldı");
            Console.WriteLine();

            Console.WriteLine("Liste1");
            liste1.ForEach(ogrEle => Console.WriteLine(ogrEle));
            Console.WriteLine();

            Console.WriteLine("Liste2");
            liste2.ForEach(ogrEle => Console.WriteLine(ogrEle));
        }
    }
}
