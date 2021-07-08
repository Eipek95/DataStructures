using System;
using System.Collections;

namespace Arrays_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array |  Dizi
            #region

            int[] sayilar = new int[] {5,3,2,10,8,18,23,44,52,9,15,65};

            var numbers = Array.CreateInstance(typeof(int),sayilar.Length);//sayilar.length elemanlı bir dizi
            //numbers.SetValue(-5,0);diziye eleman ekledik.value-index sayısı
           
            
            var arr = new ArrayList(sayilar);
            sayilar.CopyTo(numbers, 0);//kopyalanacak dizi ve hangi indexten başlanacak
            arr.Sort();
            Array.Sort(sayilar);//array referans tipli değer olmadığı için kopyalama aşamasında diğerleri etkilenmez
            Array.Sort(numbers);
            Array.Clear(sayilar,0,3);//0-1-2 indexteki elemanı sil.
            Console.WriteLine(Array.IndexOf(sayilar,44));//44 değerinin dizide kaçıncı sırada olduğunu bulur.elemanı bulamazsa -1 döner
            #endregion
            //dolaşma
            #region
            for (int i = 0; i < sayilar.Length; i++)
            {
                //ekran çıktısı
                Console.WriteLine("sayilar[{0}] = {1} - numbers[{0}] = {2}", //{0}->i {1}->sayilar {2}->numbers
                    i,
                    sayilar[i],
                    numbers.GetValue(i));
            }
            Console.WriteLine();
            // alternatif ekran çıktısı
            for (int i = 0; i < sayilar.Length; i++)
            {
                // alternatif ekran çıktısı
                Console.WriteLine($"sayilar[{i}] = " +
                   $"{sayilar[i],3} - " +
                   $"numbers[{i}] = " +
                   $"{numbers.GetValue(i),3} " +
                   $"arr[{i}]=" +
                   $"{arr[i],3}");
            }
            #endregion
        }
    }
}
