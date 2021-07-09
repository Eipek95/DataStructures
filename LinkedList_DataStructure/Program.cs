using System;
using System.Collections.Generic;

namespace LinkedList_DataStructure
{
    class Program
    {
        //amaç Doğu'dan Batı'ya Karadeniz'e kıyısı olan şehirler
        static void Main(string[] args)
        {
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");//eski first
            sehirler.AddFirst("Trabzon");//first diye ikinci kez tanımlanırsa first olan değer güncellenir.eski değer first olmaktan çıkar.yeni first
            sehirler.AddLast("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next,"Giresun");
            sehirler.AddBefore(sehirler.Last,"Sinop"); //veya -> sehirler.AddAfter(sehirler.Last.Previous,"Sinop");
            sehirler.AddAfter(sehirler.Last.Previous,"Zonguldak");//veya -> sehirler.AddAfter(sehirler.Find("Sinop"),"Zonguldak");

            Console.WriteLine();
            Console.WriteLine("Doğu'dan Batı'ya -> Gidiş Güzergahı");
            var eleman = sehirler.First;
            while (eleman!=null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Batı'dan Doğu'ya -> Dönüş Güzergahı");
            var eleman2 = sehirler.Last;
            while (eleman2 != null)
            {
                Console.Write(eleman2.Value);
                eleman2 = eleman2.Previous;
            }
        }
    }
}
