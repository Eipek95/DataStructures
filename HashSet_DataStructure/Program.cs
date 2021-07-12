using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSet_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var sesliHarf = new HashSet<char>() 
            {
                'e','ı','i','u','ü','o','ö','b'
            };
           // KoleksiyonYazdir(sesliHarf);
            sesliHarf.Add('a');
            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);


            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }
            KoleksiyonYazdir(alfabe);

            //Türkçe'de kullanılan sesli harfler
            //sesliHarf.ExceptWith(alfabe);//sesliharf/alfabe(fark) işlemini yapar
            //sesliHarf.UnionWith(alfabe);//birleştirnme işlemi yapar
            //sesliHarf.IntersectWith(alfabe);//kesişim.ortak elemanları
            sesliHarf.SymmetricExceptWith(alfabe);//sesliharf ve alfabenin kesişiminin değili
            KoleksiyonYazdir(sesliHarf);
        }
        static void KoleksiyonYazdir(IEnumerable koleksiyon)//hem hashset hemde list kabul etmesi için IEnumerable ekledik
        {
            int i = 0;
            foreach (var k in koleksiyon)
            {
                Console.Write($"{k,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("\nEleman Sayısı: {0}",i);
        }
    }
}
