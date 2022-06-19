using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jultoments dagräknare
            DaysTillXmas(DateTime.Now);

            // txeTsegnälkaB
            string myString = "qwerty";
            BaklängesText(myString); // eller "qwerty" hårdkodat

            // Siffror till text
            TalTillText(101);

            // Minsta talet först (Swap)
            MinstaTaletForst(10, 15); // - WIP

            // Medelvärdet av en array
            int[] arr = new int[] { 1, 2, 3 };
            Medelvärde(arr);

            // Överlagring
            AdderaSymboler("depeche mode är bäst");
            AdderaSymboler(101); // WIP

            // Rad av tecken
            RadAvTecken('a', 10);

            // Bromssträcka
            Bromssträcka(50);

            // Procent av...
            ProcentAv(3, 352.0);

            // Lägga till procent
            LäggTillProcent(0.01, 100.0);

            // Hur många procent är x av ett värde?
            HurMångaProcentÄr(10.0, 500);

            #region todo
            // Lucky 8ball
            #endregion
        }

        private static void HurMångaProcentÄr(double v1, double v2)
        {
            double quot = v2 / v1;
        }

        private static void LäggTillProcent(double v1, double v2)
        {
            double result = v2 + (v2 * v1);
        }

        private static void ProcentAv(double percentage, double inputVariable)
        {
            double result = (inputVariable * (percentage * 0.01));
        }

        private static void Bromssträcka(int hastighet)
        {
            // s = v^2 / ( 250 * friktionstal )
            // Friktionstal 0.8 på torr asfalt.
            double friktionstal = 0.8;
            double bromsträcka = (hastighet * hastighet) / (250 * friktionstal);
            Console.WriteLine(bromsträcka);
        }

        private static void RadAvTecken(char v1, int v2)
        {
            for (int i = 0; i < v2; i++)
            {
                Console.Write(v1);
            }
        }

        private static void AdderaSymboler(int v)
        {
            int summa = 0;
            string str = v.ToString(); // "101"
            char[] charArr = new char[str.Length]; // Lenght = 3
            for (int i = 0; i < str.Length; i++)
            {
                charArr[i] = str[i]; // Lägga till varje char i arr
                //Console.Write(charArr[i]); // skriva ut varje char
                summa = summa + charArr[i]; // 49 + 48 + 49
            }

            Console.WriteLine("Summa av heltalen i " + v + " är: " + summa); // 146
        }

        private static void AdderaSymboler(string v)
        {
            int value = 0;
            foreach (char item in v)
            {
                switch (item)
                {
                    case 'a': value += 1; break;
                    case 'b': value += 2; break;
                    case 'c': value += 3; break;
                    case 'd': value += 4; break;
                    case 'e': value += 5; break;
                    case 'f': value += 6; break;
                    case 'g': value += 7; break;
                    case 'h': value += 8; break;
                    case 'i': value += 9; break;
                    case 'j': value += 10; break;
                    case 'k': value += 11; break;
                    case 'l': value += 12; break;
                    case 'm': value += 13; break;
                    case 'n': value += 14; break;
                    case 'o': value += 15; break;
                    case 'p': value += 16; break;
                    case 'q': value += 17; break;
                    case 'r': value += 18; break;
                    case 's': value += 19; break;
                    case 't': value += 20; break;
                    case 'u': value += 21; break;
                    case 'v': value += 22; break;
                    case 'x': value += 23; break;
                    case 'y': value += 24; break;
                    case 'z': value += 25; break;
                    case ' ': value += 0; break; // Mellanslag är noll
                                                 //default:
                                                 //    Console.WriteLine("Något gick fel.");
                                                 //    break;
                }
            }
            Console.WriteLine("Summan av bokstäverna \"" + v + "\" är " + value);
        }

        private static void Medelvärde(int[] allaTal)
        {
            double mean = 0;
            foreach (var item in allaTal)
            {
                mean += item;
                mean /= allaTal.Length;
            }
            Console.WriteLine("mean: " + mean);
        }

        private static void MinstaTaletForst(int v1, int v2)
        {
            List<int> myList = new List<int>() { v1, v2 };
            if (v1 > v2) // Om v1 är större än v2 - byt plats på dem!
            {
                for (int i = myList.Count; i >= 0; i--)
                {
                    Console.WriteLine("De har bytt plats: " + myList[i]); // listan baklänges
                }
            }
            else if (v1! > v2) // Om v1 inte är större än v2 - byt inte plats!
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine("De har inte bytt plats: " + myList[i]);
                }
            }
            else Console.WriteLine("något gick fel");

            // Skriv ut i storleksordning.
            myList.Sort(); // ascending!
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("Sorterad lista: " + myList[i]);
            }
        }

        private static void TalTillText(int variable)
        {
            string numToString = variable.ToString();

            //foreach (var item in numToString) // foreach funkar inte. index out of bounds
            //{
            //    switch (numToString[item])
            //    {
            //        case '0': Console.Write("Noll"); break;
            //        case '1': Console.Write("Ett"); break;
            //        case '2': Console.Write("Två"); break;
            //        case '3': Console.Write("Tre"); break;
            //        case '4': Console.Write("Fyra"); break;
            //        case '5': Console.Write("Fem"); break;
            //        case '6': Console.Write("Sex"); break;
            //        case '7': Console.Write("Sju"); break;
            //        case '8': Console.Write("Åtta"); break;
            //        case '9': Console.Write("Nio"); break;
            //        default: Console.Write("Wtf?"); break;
            //    }
            //}

            for (int i = 0; i < numToString.Length; i++)
            {
                switch (numToString[i])
                {
                    case '0': Console.Write("Noll"); break;
                    case '1': Console.Write("Ett"); break;
                    case '2': Console.Write("Två"); break;
                    case '3': Console.Write("Tre"); break;
                    case '4': Console.Write("Fyra"); break;
                    case '5': Console.Write("Fem"); break;
                    case '6': Console.Write("Sex"); break;
                    case '7': Console.Write("Sju"); break;
                    case '8': Console.Write("Åtta"); break;
                    case '9': Console.Write("Nio"); break;
                    default: Console.Write("Wtf?"); break;

                }
            }
        }

        private static void BaklängesText(string variable)
        {
            for (int i = variable.Length - 1; i >= 0; i--)
            {
                Console.Write(variable[i]);
            }
        }

        public static void DaysTillXmas(DateTime variableFromMethodCall)
        {
            DateTime jul = new DateTime(DateTime.Now.Year, 12, 25);
            TimeSpan diff = jul - variableFromMethodCall;
            Console.WriteLine("Det är " + diff.Days + " dagar till jul.");
        }
    }
}