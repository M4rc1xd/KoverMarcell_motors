using System;
using System.Collections.Generic;
using System.IO;

namespace Motorok
{
    public class Statisztika
    {
        List<Motor> motorok = new List<Motor>();

        public void ReadFromFile(string fileName){
            StreamReader sr = new StreamReader(fileName);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] parts = sr.ReadLine().Split(';');
                motorok.Add(new Motor(parts[0], parts[1], int.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4])));
            }
            sr.Close();
            foreach (var motor in motorok)
            {
                System.Console.WriteLine(motor);
            }
        }

        public int SumPrices(){
            double sum = 0;
            foreach (var motor in motorok)
            {
                sum += motor.PriceInEur;
            }
            return Convert.ToInt32(sum);
        }

        public bool Contains(string motorName){
            foreach (var motor in motorok)
            {
                if (motor.Brand == motorName)
                {
                    return true;
                }
            }
            return false;
        }

        

    }
}