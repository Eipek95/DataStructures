using System;
using System.Collections.Generic;

namespace Queue_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            AppQueue appQueue = new AppQueue();
         
        }

        private static void queueStructure()
        {
            //oluşturma
            var karakterKuyrugu = new Queue<char>();
            //ekleme
            karakterKuyrugu.Enqueue('A');
            karakterKuyrugu.Enqueue('E');
            Console.WriteLine($"Eleman Sayısı: {karakterKuyrugu.Count}");

            //diziye ekleme
            var dizi = karakterKuyrugu.ToArray();

            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"Kuyruktan çıkarılan eleman: {karakterKuyrugu.Dequeue()}");
            Console.WriteLine($"Eleman Sayısı: {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
        }
    }
}
