using System;

namespace Motorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statisztika statisztika = new Statisztika();
            statisztika.ReadFromFile("motors.txt");
            System.Console.WriteLine("Összes motor ára egyben: "+statisztika.SumPrices() +" EUR");
            System.Console.WriteLine("Van-e benne Bear 650: "+statisztika.Contains("Bear 650"));
            System.Console.WriteLine("Legöregebb motor: "+statisztika.Oldest());
            System.Console.WriteLine("Yamaha motorok ára egyben: "+statisztika.SumBasedOnBrand("Yamaha") +" EUR");
        }
    }
}