using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Man kan ha räknaren inne i loopen, eller variabeln innan loopen, eller inget i loopen:
            //for (;;)
            //{

            //} // Evig loop, samma som while (true)

            var a = (int)'a'; // a omvandlas till int 96
            var b = 'a' + 'b'; // 96 + 97?

            // ALFABETET:
            CharsLoop();

            // COUNT DOWN:
            CountDown(10);

            // COUNT DOWN FROM:
            CountDownFrom(5, 1);

            // COUNT FROM:
            CountFrom(10, 15);

            // NAMN SOM BÖRJAR MED GIVEN BOKSTAV:
            ListNamesThatStartsWith('B', "Batman", "Superman", "Borat"); // en char och en array

            // NAMN SOM SLUTAR MED EN GIVEN BOKSTAV:
            ListNamesThatEndWith('h', "Hulk", "Spiderman", "Flash", "Green Arrown");

            // BAKLÄNGES NAMN:
            NameScrambler("Camilla");

            // ASCII VALUES:
            AsciiValues("Bruce Wayne");
        }

        public static void CharsLoop()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i);
            }
        }

        public static void CountDown(int start)
        {
            for (int i = start; i >= 0; i--)
            {
                Console.Write(i + ".."); // Hur få bort sista punkterna?
            }
        }

        public static void CountDownFrom(int start, int stop)
        {
            for (int i = start; i >= stop; i--)
            {
                Console.Write(i);
            }
        }

        public static void CountFrom(int start, int stop)
        {
            for (int i = start; i <= stop; i++)
            {
                Console.Write(i);
            }
        }
    
        /// <summary>
        /// Tar emot en char och en array. Skriver ut alla namn som börjar med den bokstaven, och hur många de är.
        /// </summary>
        /// <param name="firstLetter"></param>
        /// <param name="names"></param>
        public static void ListNamesThatStartsWith(char firstLetter, params string[] names)
        {
            // Params gör att man slipper skapa en array, se rad 31.

            int counter = 0;
            foreach (var item in names)
            {
                if (item.StartsWith(firstLetter)) // names[0] == firstLetter funkar inte!
                {
                    counter++;
                    Console.WriteLine(item); // Batman, Borat
                }
            }
            Console.WriteLine(counter); // 2

            // OBS item.StartWith kan hantera strängar, names[0] kan bara kolla ett tecken åt gången!
            // Dessutom, om [] är tom kraschar programmet, medan StartsWith returnerar false.
        }

        private static void ListNamesThatEndWith(char lastLetter, params string[] names )
        {
            int counter = 0;
            foreach (var item in names)
            {
                if (item.EndsWith(lastLetter))
                    // if (item[item.Length - 1] == 'h')
                    // if (item[^1] == 'h') // ^ räknar baklänges, så -1
                    // if (item.Substring(item.Length - 1) == "h") // obs ej 'h'!
                {
                    counter++;
                    Console.WriteLine(item); // Flash
                }
            }
            Console.WriteLine(counter); // 1
        }
    
        private static void NameScrambler(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

        private static void AsciiValues(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("char " + name[i] + " ascii value is " + (int)name[i]);
            }
        }
    }
}
