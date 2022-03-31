using System;

namespace Practic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(40,40,1,"Mercedes","Black",50000);
            Console.WriteLine(Car.Add("BMW","Blue",30000,40,2));
            Car.Drive(30, 1, 30, 0); 
        }
    }
}
