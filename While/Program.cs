using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            // While behöver ingen räknare (men kan ha). Bra när man inte vet hur många gånger man ska loopa.

            //      GuessMyNumber(); // 10 är max här
            //GuessMyNumber(15);
            //GuessMyNumber(5);

            // NESTED LOOPS:
            NestedLoops(3);

            // COUNT UP OR DOWN:
            CountUpOrDown(4, 7); // Funkar inte att räkna upp, bara ner?
            CountUpOrDown(6, 2);
        }

        public static void GuessMyNumber(int max = 10) // (Om metoden anropas utan int-param, kommer int-param bli 10)
        {
            var slumpgenerator = new Random();
            var randomNumber = slumpgenerator.Next(1, max + 1); // Hämta ett slumptal mellan 1 och max.
            int userGuess = int.Parse(Console.ReadLine());
            while (userGuess != randomNumber)
            {
                if (userGuess == randomNumber) 
                {
                    Console.WriteLine("Rätt!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel!");
                    userGuess = int.Parse(Console.ReadLine());
                    if (userGuess== randomNumber)
                    {
                        Console.WriteLine("rätt");
                    }
                }
            }

            // FACIT:
            //var random = new Random();
            //var randNr = random.Next(1, max + 1);
            //var guess = 0;
            //while (guess!= randNr)
            //{
            //    Console.WriteLine("Gissa ett tal mellan 1 och " + max);
            //    var input = Console.ReadLine();
            //    _ = int.TryParse(input, out guess);
            //}
        }

        public static void NestedLoops(int max = 3)
        {
            //int value = 0;
            //int counter = 0;
            //while (counter < max)
            //{
            //    value++;
            //    Console.WriteLine("Loopvärde: " + value);
            //    counter++;
            //    if (counter == max) break;
            //}
            
            // WIP...

            // FACIT: 
            int counterA = 0;
            while (counterA++ < max)
            {
                int counterB = 0;
                while (counterB++ < max)
                {
                    Console.WriteLine("Loop värde: " + counterA + " : " + counterB);
                }
            }
        }

        public static void CountUpOrDown(int start, int stop)
        {
            // FACIT:
            int diff = 1;
            if (start > stop)
            {
                diff = -1;
                int counter = start;
                Console.WriteLine($"Loop: {start} - {stop}");
                while (true)
                {
                    Console.WriteLine("Counter = " + counter);
                    counter += diff;
                    if (diff == 1 && counter > stop)
                    {
                        break;
                    }
                    if (diff == -1 && counter < stop)
                    {
                        break;
                    }
                }
            }
        }
    }
}
