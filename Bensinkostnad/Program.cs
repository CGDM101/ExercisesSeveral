using System;

namespace Bensinkostnad
{
    class Program
    {
        static void Main(string[] args) // WIP
        {
            double distance = 344.24; // km
            double fuelConsumption = 6.7; // l per 100 km
            double fuelPrice = 17.24; // per l
            double price = (fuelConsumption * 3.4424) * 17.24;

            Console.WriteLine("Kostnad{0} ", price); // ~ 398
        }
    }
}