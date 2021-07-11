using System;
using System.Collections.Generic;

namespace Dictionary_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDictionary appDictionary = new AppDictionary();
            //TelefonRehber();
        }

        private static void TelefonRehber()
        {
            var telefonKodlari = new Dictionary<int, string>()
            {
                { 332,"Konya"},
                { 424,"Elazığ"},
                { 466,"Art"}
            };

            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");


            //erişme
            telefonKodlari[466] = "Artvin";
            //containskey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni Kod Eklendi");
            }
            //containsvalue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni Kod Eklendi");
            }
            //remove
            telefonKodlari.Remove(322);
            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }
        }
    }
}
