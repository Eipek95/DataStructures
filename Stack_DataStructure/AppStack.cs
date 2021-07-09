using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_DataStructure
{
    //kullanıcıdan alınan sayının basamak değerlerini bulma
    public class AppStack
    {
        public void digitCalculation()
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            var sayiYigini = new Stack<int>();
            while (sayi>0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x " +
                    $"{Math.Pow(10,n-i),7}\t = " +
                    $"{s*Math.Pow(10,n-i),7}");
                i++;
            }
        }
    }
}

