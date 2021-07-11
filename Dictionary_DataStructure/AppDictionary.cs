using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_DataStructure
{
    class AppDictionary
    {
        public AppDictionary()
        {
            PersonelTransaction();
        }

        public void PersonelTransaction()
        {
            var personelListesi = new Dictionary<int, Personel>() 
            {
                { 110,new Personel("Mehmet","Sonsoz",7500) },
                { 120,new Personel("Ahmet","Can",9000) },
            };
            personelListesi.Add(100,new Personel("Zeynep","Çoşkun",5000));

            foreach (var item in personelListesi)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
