using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HashTable_DataStructure
{
    class AppHashTable
    {
        //amaç kulanıcının girdiği başlığa göre sitenin url oluşsun
        public void Url()
        {
            Console.WriteLine("Başlık giriniz: ");
            string baslik = Console.ReadLine();

            //kucultme
            baslik=baslik.ToLower();
            //hashtable
            var karekterSeti = new Hashtable() 
            {
                //anahtarlar tekil olmalı
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','_'},
                {'ğ','g'},
                {'?','-'}
            };
            foreach (DictionaryEntry item in karekterSeti)
            {
                baslik = baslik.Replace((char)item.Key,(char)item.Value);//unboxing
            }

            //ekrana yazdir
            Console.WriteLine(baslik);
        }
    }
}
