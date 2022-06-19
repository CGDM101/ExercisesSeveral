using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // En tupel är ett dynamiskt objekt som anpassar sig enligt vad vi behöver. Det blir ett objekt som kan innehålla fler än ett värde i en och samma variabel, utan att behöva skapa en speciell klass för det.

            Tuple<string, int> person = new Tuple<string, int>("Peter Parker", 17);
            var p = ("Peter Parker", 17); // Variant



            // Metoder kan också returnera tupler.
            static (string, int) Sök(string namw)
            {
                var namn = "";
                var ålder = 0;
                // ... kod
                return (namn, ålder);
            }
            var batman = Sök("Bruce Wayne");
            Console.WriteLine(batman.Item1 + " " + batman.Item2); // Item syftar till tupleinstansens element.

            // Variant
            (string namn, int ålder) = Sök("Bruce Wayne");
            Console.WriteLine(namn + " " + ålder);
        }
    }
}