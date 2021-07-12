using System;
using System.Collections.Generic;
using System.Text;

namespace SortedSet_DataStructure
{
    class AppSortedSetCluster
    {
        public AppSortedSetCluster()
        {
            Clusters();
        }

        //cluster->küme
        public void Clusters()
        {
            //var A = new SortedSet<int>() {1,2,3,4 };
            //var B = new SortedSet<int>() {1,2,5,6 };
            var A = new SortedSet<int>(RasgeleSayiUret(10));//sortedlist unique değerlidir
            var B = new SortedSet<int>(RasgeleSayiUret(3));//sortedlist unique değerlidir
            #region Çıktı
            Console.WriteLine();
            Console.WriteLine("A Kümesi");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine("\nA eleman Sayısı: {0}",A.Count);
            Console.WriteLine();
            Console.WriteLine("B Kümesi");
            foreach (var x in B)
            {
                Console.Write($"{x,5}");
            }
            Console.WriteLine("\nB eleman Sayısı: {0}", B.Count);
            #endregion

            #region Union-Birlesim
            /*
            //birleşim->union
            Console.WriteLine("\nA eleman sayisi: {0} ve B eleman sayisi: {1}", A.Count,B.Count);
             A.UnionWith(B);//B'nin referansını A verdik yani A artık 1,2,3,4,5,6 oldu

             Console.WriteLine("\nA ve B kümesinin Birleşimi(AuB) UnionWith");
             foreach (var item in A)
             {
                 Console.Write($"{item,5}");
             }
             Console.WriteLine("\nA eleman sayisi: {0}",A.Count);
            */
            #endregion

            #region IntersectWith-Kesisim
            /*
            //kesişim->IntersectWith
            A.IntersectWith(B);
            Console.WriteLine();
            Console.WriteLine("\nA ve B kümesinin Kesilim(AnB) IntersectWith");
            foreach (var item in A)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine("\nA eleman sayisi: {0}", A.Count);
            */
            #endregion

            #region ExceptWith-Fark
            /*
            //fark->ExceptWith
            A.ExceptWith(B);
            Console.WriteLine();
            Console.WriteLine("\nA'nın  B'den Farkı(A/B) ExceptWith");
            foreach (var item in A)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine("\nA eleman sayisi: {0}", A.Count);
            */
            #endregion

            #region SymmetricExceptWith-(AnB)'
            //(AnB)'->SymmetricExceptWith
            A.SymmetricExceptWith(B);
            Console.WriteLine();
            Console.WriteLine("\nA ve  B'nin kesişiminin değili(AnB)' SymmetricExceptWith");
            foreach (var item in A)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine("\nA eleman sayisi: {0}", A.Count);
            #endregion


            A.IsSubsetOf(B);//A B'nin bir alt kümesi mi? a tüm elemanları b'de var mı
        }


        static List<int> RasgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random ();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0,10)) ;
            }
            return list;
        }
    }
}
