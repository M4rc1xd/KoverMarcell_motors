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
            System.Console.WriteLine("Van-e benne Yamaha: "+statisztika.Contains("Yamaha"));
        }
    }
}