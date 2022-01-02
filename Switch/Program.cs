using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            SwedishMonthName(8);
            SwedishMonthName(10);
            SwedishMonthName(100); // "Nåt fel"

            SwedishDayName(2);
            SwedishDayName(4);
            SwedishDayName(-1);
        }

        private static void SwedishDayName(int day)
        {
            string dayName;
            switch (day)
            {
                case 1: dayName = "Måndag"; break;
                case 2: dayName = "Tisdag"; break;
                case 3: dayName = "Onsdag"; break;
                case 4: dayName = "Torsdag"; break;
                case 5: dayName = "Fredag"; break;
                case 6: dayName = "Lördag"; break;
                case 7: dayName = "Söndag"; break;
                default: dayName = "Uh?"; break;
            }
            Console.WriteLine(dayName);
        }

        private static void SwedishMonthName(int month)
        {
            string monthName;
            switch (month)
            {
                case 1: monthName = "Januari"; break;
                case 2: monthName = "Febuari"; break;
                case 3: monthName = "Mars"; break;
                case 4: monthName = "April"; break;
                case 5: monthName = "Maj"; break;
                case 6: monthName = "Juni"; break;
                case 7: monthName = "Juli"; break;
                case 8: monthName = "Augusti"; break;
                case 9: monthName = "September"; break;
                case 10: monthName = "Oktober"; break;
                case 11: monthName = "November"; break;
                case 12: monthName = "December"; break;
                
                default: monthName = "Nåt fel"; break;

                    //case 1: Console.WriteLine("Januari"); break;
                    //case 2: Console.WriteLine("Februari"); break;
                    //case 3: Console.WriteLine("Mars"); break;
                    //case 4: Console.WriteLine("April"); break;
                    //case 5: Console.WriteLine("Maj"); break;
                    //case 6: Console.WriteLine("Juni"); break;
                    //case 7: Console.WriteLine("Juli"); break;
                    //case 8: Console.WriteLine("Augusti"); break;
                    //case 9: Console.WriteLine("September"); break;
                    //case 10: Console.WriteLine("Oktober"); break;
                    //case 11: Console.WriteLine("November"); break;
                    //case 12: Console.WriteLine("December"); break;
                    //default: Console.WriteLine("Nåt fel?"); break;
            }
            Console.WriteLine(monthName);
        }
    }
}
