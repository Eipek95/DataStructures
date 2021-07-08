using System;

namespace StructureValueType
{
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        /*default constructor yapısını structlarda kullanamayız
        public Nokta()
        {
        }
        */
        //default constructor yerine parametreli structor kullanılır
        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Yapımız yeni üye ->method
        public void SetOrigin()
        {
            X = 0;
            Y = 0;
        }
        public void Degistir()
        {
            //iki noktanın yer değiştirmesi x y oluyor y de x 
            var gecici = X;
            X = Y;
            Y = gecici;
        }
    }
    class Program
    {
        //struct--->değer tipli
        static void Main(string[] args)
        {
            var n1 = new Nokta(3,4);
            Console.WriteLine($"n1: {n1}");

            n1.Degistir();
            Console.WriteLine($"değişen n1: {n1}");

            var n2 = n1;//deger alırız adresi değil.n2 üzerinde yapılacak bir değişiklik n2 yi etkilemez
            Console.WriteLine($"n2: {n2}");

            n2.X = -1 * n2.X;
            Console.WriteLine(n2);

            n1.SetOrigin();
            Console.WriteLine($"n1: {n1}");
        }
    }
}
