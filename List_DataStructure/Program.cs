using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace List_DataStructure
{
   
    public class Sehir :IComparable<Sehir>
    {
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }
        public override string ToString()
        {
            return $"{PlakaNo,-5} {SehirAdi,-15}";
        }

        public int CompareTo(Sehir plaka)
        {
            if (this.PlakaNo<plaka.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo==plaka.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>() { 56,95,2,7,8,10,65,45};
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));


            //Sehir Listesi
            var sehirler = new List<Sehir>
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(44,"Malatya")
            };
            sehirler.Add(new Sehir(1,"Adana"));
            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
        }
    }
}
