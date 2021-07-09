using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_DataStructure
{
    //kullanıcının isteeğine göre sesli harfleri kuyruğa ekleme
    public class AppQueue
    {
        public AppQueue()
        {
            methodVowel();
        }

        public void methodVowel()
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };
            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();
           
            foreach (var item in sesliHarfler)
            {
                Console.WriteLine($"{item,-5} kuyruğa eklensin mi? [e/h] ");
                secim=Console.ReadKey();
                Console.WriteLine();
                if (secim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(item);
                    Console.WriteLine($"\n{item,-5} kuyruğa kuyruğa eklendi");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: { kuyruk.Count}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuyruktan Elemanlarin kaldirilmasi için Esc tuşuna basınız");
            secim = Console.ReadKey();

            if (secim.Key==ConsoleKey.Escape)
            {
                Console.WriteLine();

                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek()} kuyruktan çıkartılıyor");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkarıldı");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: { kuyruk.Count}");
                }
                Console.WriteLine("\n Kuyruktan Çıkarılma İşlemi Tamamlandı");

            }
            Console.WriteLine("Program Bitti");
            
        }
    }
}
