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

            // NÄSTLADE LOOPAR: =========================================== WIP


            // MER WHILE:

            // Gör en While loop som ska köra max 5 gånger. I den slumpar du fram tal mellan 1 och 100.
            Console.WriteLine("WHILE:");

            int counter = 0;
            while (counter < 5) // Måste var fem?! Eller att counter börjar på 1.
           {
                counter++;
                Random random = new Random();
                int tal = random.Next(1, 101);
                Console.WriteLine(tal);
            }

            // Gör en while loop som körs tills ett slumptal mellan 1 och 100 blir 55
            Console.WriteLine("while igen:");

            int räknare = 0; // Egentligen inte nödvändig för uppgiften.

            int slumptal = 0;
            while (slumptal != 55)
            {
                Random rng = new Random();
                slumptal = rng.Next(1, 101);
                Console.WriteLine(slumptal);

                räknare++;
            }
            Console.WriteLine("Det tog " + räknare + " ggr att nå 55");


            // MER DOWHILE:
            Console.WriteLine("do while:"); // ======================================= WIP

            bool check = true;
            do // så länge check är sant.
            {
                check = !check; // ändra check till false.
                Console.WriteLine(check); // skriva ut checks värde för varje runda.
            } while (check);

            // Skriv ett spel där datorn ska gissa ett tal mellan 1 och 1000 som du tänker på.
            Console.WriteLine("gissa numret:");

            int myNum = 101;
            int computerGuess;
            do
            {
                Random r = new Random();
                computerGuess = r.Next(1, 1001);
            } while (myNum != computerGuess);

            //if (computerGuess < myNum)
            //{
            //    Console.WriteLine("För lågt! Gissa igen!");
            //}
            //else if (computerGuess > myNum)
            //{
            //    Console.WriteLine("För högt! Gissa igen!");
            //}
            //else if (computerGuess == myNum)
            //{
            //    Console.WriteLine("yes!!");
            //}

        }
    }
}
