using System;
using System.Collections.Generic;
using System.Text;

namespace SortedSet_DataStructure
{
    
    class AppSortedSet
    {
        public AppSortedSet()
        {
            RandomList();
        }

        public void RandomList()
        {
            var sayilar = new List<int>();
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0,10));
                Console.Write($"{sayilar[i],-3}");
            }
            var benzersizSayiListesi = new SortedSet<int>(sayilar);
            Console.WriteLine();

            Console.WriteLine("\n Benzersiz Sayi Listesi");
            foreach (var item in benzersizSayiListesi)
            {
                Console.WriteLine($"{item,-3}");
            }
            Console.WriteLine("Benzersiz {0} sayi var. ",benzersizSayiListesi.Count);
        }
    }
}
