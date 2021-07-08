using System;
using System.Collections;

namespace SortedList_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new AppSortedList();
            app.Contents();

            var list = new SortedList()
            {
                { 1,"Bir" },
                { 2,"İki" },
                { 3,"Üç" },
                { 8,"Sekiz" },
                { 5,"Beş" },
                { 6,"Altı" },
        };
            list.Add(4,"Dört");
            list.Add(7,"Yedi");
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.WriteLine("Listedeki Eleman Sayısı: {0}", list.Count);
            Console.WriteLine("Listenin Kapasitesi:     {0}", list.Capacity);//maksimum kapasiteyi verir
            list.TrimToSize();//listedeki eleman sayısına göre kapasiteyi set eder
            Console.WriteLine("Listenin Kapasitesi:     {0}", list.Capacity);

            //Erişme
            //Key
            Console.WriteLine(list[4]);//burada indis değil keydir.yani keye karşılık gelen değeri verir.4->dört
            //İndex
            Console.WriteLine(list.GetByIndex(4));//belirtilen indeksteki değeri getir.yani 4.indeksteki değeri getirir
            //Get ->Key
            Console.WriteLine(list.GetKey(0));//belirtilen indeksteki değerin keyini getirir.
            //son elemanı
            Console.WriteLine(list.GetByIndex(list.Count-1)); //listenin sonundaki elemanı getir
            //son elemanın anahtarı
            Console.WriteLine(list.GetKey(list.Count-1)); //son elemanın anahtarı

            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            var degerler = list.Values;
            Console.WriteLine("\nDeğerler");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGuncelleme");
            if (list.Contains(1))//eğer 1 nolu key varsa onun değerini al ve güncelle
            {
                list[1] = "One";
            }

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("\nSilme");
            list.Remove(1);
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
