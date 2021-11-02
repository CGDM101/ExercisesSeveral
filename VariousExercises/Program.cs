using System;
using System.Linq;

namespace VariousExercises
{
    class Program // Övningar repetion heter dokumentet.
    {
        static void Main(string[] args)
        {
            // ==========
            // 1 TILL 10
            // ==========
            Console.WriteLine("For:");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("While istället:");
            int ii = 0;
            while (ii < 10)
            {
                ii++;
                Console.WriteLine(ii);
            }

            Console.WriteLine("Do while:");
            int iii = 0;
            do
            {
                iii++;
                Console.WriteLine(iii);
            } while (iii < 10);

            // ==========
            // 10 TILL 1
            // ==========
            Console.WriteLine("For");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("While istället:");
            int x = 11;
            while (x > 1)
            {
                x--;
                Console.WriteLine(x);
            }

            Console.WriteLine("Do while:");
            int xx = 11;
            do
            {
                xx--;
                Console.WriteLine(xx);
            } while (xx > 1);


            // SKRIV BAKLÄNGES:
            Console.Write("Skriv in ett namn: ");
            string input = Console.ReadLine();
            for (int i = input.Length -1; i >= 0; i--) // Måste var >= och inte bara >, annars kommer inte sista bokstaven med.
            {
                Console.Write(input[i] + " ");
            }

            // FOREACH:
            string[] arr = new string[] { "Adam", "Bertil", "Caesar" };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Samma som ovan, fast baklänges:
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // NÄSTLADE LOOPAR:
        }
    }
}
