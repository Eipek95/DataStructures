using System;
using System.Collections;

namespace HashTable_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            AppHashTable appHashTable = new AppHashTable();
            appHashTable.Url();
            //hashtable
            var sehirler = new Hashtable();

            //ekleme
            sehirler.Add(6,"Ankara");
            sehirler.Add(7,"Antalya");
            sehirler.Add(21,"Diyarbakır");
            sehirler.Add(34,"İstanbul");
           
            //dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"{item.Value,-20}");
            }

            //Anahtarları alma
            var anahtarlar = sehirler.Keys;
            Console.WriteLine($"Anahtarlar (keys)");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine($"{item}");
            }

            //Değerleri alma
            Console.WriteLine("Değerler Alma");
            var degerler = sehirler.Values;//ICollection yada var
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }


            //elemana erişme
            Console.WriteLine("\nElemana Erişme");
            Console.WriteLine(sehirler[21]);//hashtable de indeksleme olmadığı için indeksini değilde keyini yazarak elemanı getirdik
           
            //elemana silme
            Console.WriteLine("\nEleman Silme");
            sehirler.Remove(34);
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"{item.Value,-20}");
            }
        }
    }
}
