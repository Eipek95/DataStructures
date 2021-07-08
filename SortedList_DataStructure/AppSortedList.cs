using System;
using System.Collections;
using System.Text;

namespace SortedList_DataStructure
{
    //amaç bir videonun veya kitabın içindekiler sayfası hazırlama(kitap için 1.sayfada şu konu,videoda 1.dk şu olay vs)
    public class AppSortedList
    {
        public void Contents()
        {
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1,"Önsöz");
            kitapIcerigi.Add(50,"Değişkenler");
            kitapIcerigi.Add(40,"Operatörler");
            kitapIcerigi.Add(60,"Döngüler");
            kitapIcerigi.Add(45,"İlişkisel Operatörler");


            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-',25));
            Console.WriteLine($"{"Konular",-33} {"Sayfalar",8}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,8}");
            }
            Console.WriteLine();
            
        }
    }
}
