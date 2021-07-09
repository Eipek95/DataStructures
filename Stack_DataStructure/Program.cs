using System;
using System.Collections.Generic;

namespace Stack_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            AppStack app = new AppStack();
            app.digitCalculation();
        }

        private static void StackOfChar()
        {
            var karekterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karekterYigini.Push((char)i);
                Console.WriteLine($"{karekterYigini.Peek()} yığına eklendi");
            }
            Console.WriteLine($"Yığında toplam {karekterYigini.Count}  tane eleman var");

            var dizi = karekterYigini.ToArray();//diziye dönüştürme işlemleri
            Console.WriteLine("Yığından Çıkartma için bir tuşa basınız");
            Console.ReadKey();
            while (karekterYigini.Count > 0)
            {
                Console.WriteLine($"{karekterYigini.Pop()} yığından çıkarıldı");
                if (karekterYigini.Count == 0)
                {
                    Console.WriteLine("Eleman Kalmadı işlem sonlandı");
                }
            }
        }

        private static void StackExample()
        {
            var karekterYigini = new Stack<char>();//stack of char

            //Ekleme
            karekterYigini.Push('e');
            karekterYigini.Push('b');
            karekterYigini.Push('d');
            karekterYigini.Push('x');
            karekterYigini.Push('a');

            //peek noktası--en son eleman
            Console.WriteLine(karekterYigini.Peek() + " yığından çıkarıldı");

            //çıkarma
            karekterYigini.Pop();
            Console.WriteLine(karekterYigini.Peek() + " sıradaki eleman");
        }
    }
}
