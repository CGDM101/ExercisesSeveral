using System;

namespace HurMångaTärningsslag
{
    class Program
    {
        static void Main(string[] args) // WIP
        {
            int counter = 0;

            while (true)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 7);
                if (number!=6)
                {
                    counter++;
                    Console.WriteLine("Försök: " + counter);
                }
                if (number==6)
                {
                    break;
                }
            }
        }
    }
}
