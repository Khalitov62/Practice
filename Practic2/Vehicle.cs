using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    internal class Vehicle
    {
        public string Brand;
        public string Color;
        public static int Millage=0;

        public Vehicle(string brand, string color,int millage)
        {
            Brand = brand;
            Color = color;
            Millage = millage;

        }
        public virtual void ShowInfo(string brand, string color, int millage)
        {

        }
    }
}
