using System;
using System.Collections.Generic;

namespace SortedSet_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicSortedSet();
            //AppSortedSet appSortedSet = new AppSortedSet();
            AppSortedSetCluster cluster = new AppSortedSetCluster();
        }

        private static void BasicSortedSet()
        {
            var list = new SortedSet<string>();
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi");

            }
            else
            {
                Console.WriteLine("Mehmet eklenmedi");

            }
            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet Eklendi" : "Ekleme başarısız");

            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fatih");
            list.Add("Fahrettin");

            //list.Remove("Fahrettin");
            list.RemoveWhere(x => x.Contains("Ayse"));
            list.RemoveWhere(x => x.StartsWith("F"));
            Console.WriteLine("\nİsimler Listesi\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.Count);
        }
    }
}
