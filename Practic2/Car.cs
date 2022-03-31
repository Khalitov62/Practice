using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    internal class Car : Vehicle
    {
        public static byte FuelCapasity;
        public static byte CurrentFuel=0;
        public static byte FuelFor1km=1;

        public Car(byte fuelcapasity, byte currentfuel, byte fuelfor1km,string brand,string color,int millage):base(brand,color,millage)
        {
            FuelCapasity = fuelcapasity;
            CurrentFuel = currentfuel;
            FuelFor1km = fuelfor1km;


        }
        public static void Drive(byte fuelcapasity,byte fuelfor1km,byte currentfuel,int millage)
        {
            
            if (FuelCapasity>=FuelFor1km)
            {
                CurrentFuel--;
                Millage++;
            }
            else
            {
                Console.WriteLine("Mashin xarabdi");
            }
            
            

        }

        public static string Add(string brand, string color, int millage, byte fuelcapasity,byte fuelfor1km)
        {
            return $"Brand : {brand}, Color : {color}, Millage : {Millage}, Fuelcapasity: {FuelCapasity}, Fuelfr1km : {FuelFor1km}";
            
        }
    }
}
