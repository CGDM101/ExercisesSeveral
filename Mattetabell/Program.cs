using System;

namespace Mattetabell
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int tal = 1; tal <= 10; tal++)
            {
                for (int multi =1; multi <= 10; multi++)
                {
                    Console.Write(tal * multi + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
