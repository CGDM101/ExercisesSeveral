using System;

namespace DateTimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2021, 12, 24);
            DateTime today = DateTime.Now;
            //DateTime bday = new DateTime("Sep 25, 1919");

            var xmasWeekday = new DateTime(DateTime.Now.Year, 12, 25).DayOfWeek;
            var daysTilXmas = new DateTime(DateTime.Now.Year, 12, 25).DayOfYear;

            var nextMonth = DateTime.Now.AddMonths(1);
            var nextWeek = DateTime.Now.AddDays(7);
            var lastWeek = DateTime.Now.AddDays(-7);
            var nextHour = DateTime.Now.AddHours(1);
            var tenMinutesAgo = DateTime.Now.AddMinutes(-10);
            var inHalfAnHour = DateTime.Now.AddMinutes(30);

            var daysTillChristmas = (new DateTime(DateTime.Now.Year, 12, 24) - DateTime.Now).TotalDays;

            DateInOneWeek();

            HalloweenWeekday();

            var maggio = new DateTime(1981, 3, 15);
            ConceptionDay(maggio);

            TodayInfo();
        }

        public static void DateInOneWeek()
        {
            DateTime x = DateTime.Now.AddDays(7);
            //var hej = x.ToString("dd MMMM yyyy");
            //Console.WriteLine(hej);
            Console.WriteLine(x.ToString("dd MMMM yyyy"));
        }

        public static void HalloweenWeekday()
        {
            var halloween = new DateTime(DateTime.Now.Year, 10, 31).DayOfWeek;
            Console.WriteLine(halloween);
        }

        public static void ConceptionDay(DateTime birthday)
        {
            var conception = birthday.AddMonths(-9);

            Console.WriteLine("Född                : " + birthday.ToString("dd MMM yyyy"));
            Console.WriteLine("Befruktningsdatum   : " + conception.ToString("dd MMM yyyy"));
        }
    
        public static void TodayInfo()
        {
            var today = DateTime.Now;
            Console.WriteLine("Datum        : " + today.ToString("dd MMM yyyy"));
            Console.WriteLine("Nummer       : " + today.DayOfYear);       // ====== ?
            Console.WriteLine("Veckodag     : " + today.DayOfWeek.ToString());
            Console.WriteLine("Sommartid    : " + today.IsDaylightSavingTime());

            if (DateTime.Today.IsDaylightSavingTime())
            {
                Console.WriteLine("Sommartid");
            }
            else
            {
                Console.WriteLine("Vintertid");
            }
        }
    }
}
