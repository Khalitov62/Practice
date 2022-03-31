using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    internal class Bycle : Vehicle
    {
        public Bycle(string brand, string color, int millage) : base(brand, color, millage)
        {
        }

        public static void Drive()
        {
            Millage++;
        }
    }
}
