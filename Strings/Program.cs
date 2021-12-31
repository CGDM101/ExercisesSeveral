using System;
using System.Text; // StringBuilder

namespace Strings
{
    // EXTENSION - En metod som beter sig som en del av en klass. Man använder extensions för att bygga på redan existerande klasser. De måste alltid ligga i statiska klasser och måste ha this på sin första parameter. This bestämmer också vilken typ vår extension ska kopplas till. T ex Scramble(this string).

    // INT.TRYPARSE ger en bool som berättar huruvida texten är numerisk eller inte.

    class Program
    {

        static void Main(string[] args)
        {
            var myString1 = new string("");
            var myString2 = string.Empty;
            //var myString3 = myObject.ToString();

            var lines = new string('-', 100); // 100 streck på rad

            // Split() returnerar array och använder angiven char som separator:
            var text = "A rose by any other name would smell as sweet. - Shakespeare".Split(' ');
            foreach (var word in text)
            {
                Console.WriteLine(word); // Varje ord på varsin rad.
            }

            // ========= EXEMPEL EXTENSION-METOD (se klass nedan!) =======

            var textKatt = "Min katt är hungrig!".Words();
            foreach (var word in textKatt)
            {
                Console.WriteLine(word);
            }
            // ========================

            // Man kan alltid omvandla en sträng till en char array:
            var hello = "Hello";
            var chars = hello.ToCharArray();

            Console.WriteLine(hello[4]); // o

            // Man kan inte skriva över en char; man får omvandla till en char array, ändra det index man vill, och sedan omvandla tillbaks till en sträng.
            char[] allChars = hello.ToCharArray();
            allChars[0] = 'Y';
            string yell0 = new string(allChars);

            // ======= SCRAMBLE ============
            Console.WriteLine("Frank Sinatra".Scramble());

            // ======= LEFT =============
            var sup = "Superman".Left(5);
            Console.WriteLine(sup); // Super

            // ======= RIGHT ===========
            var super = "Superman".Right(3);
            Console.WriteLine(super); // man

            // ====== INITIALER =========
            Console.WriteLine("Camilla Gustafsson".Initials());

            // ======= TRY PARSE ========
            Console.WriteLine("Is Numeric:" + int.TryParse("101", out int something)); // true
            Console.WriteLine("Is numeric:" + int.TryParse("Katt", out int something2)); // false

            // ==== ADD ============
            Console.WriteLine("5".Add(100));
            Console.WriteLine("3".Add(7));

            // ======= TO INT =========
            var bender1 = "10101";
            Console.WriteLine(bender1.ToInt() + 1); // 10102

            // ====== IS NUMERIC AGAIN ======
            var bender2 = "10101";
            Console.WriteLine(bender2.IsNumeric());
            Console.WriteLine("Katt".IsNumeric());

            // =========== TEXTMALLAR ========= funkar inte
            Console.WriteLine("Hej {0}, hoppas du mår {1}", "Peter", "OK"); // Console.WriteLine använder sig av StringFormat.
            string name = "Jeppe";
            string mood = "fantastiskt bra";
            var greeting = ("Hej {0}, hoppas du mår {1}", name, mood);
            var greetingSomFunkar = ($"Hej {name}, hoppas du mår {mood}");
            Console.WriteLine(greeting);
            // Ordningen saker skrivs ut är oviktigt, bara ordningen de lagts i är viktig. Man kan även använda samma parameter flera gånger. T ex "hoppas du mår {1}{1}" (OKOK)

            // ======== BOND GREETING ==========
            var namee = "James";
            var lastName = "Bond";
            var greetingg = StringMetoderRepetition.BondGreeting(namee, lastName);
            Console.WriteLine(greetingg);

            // ======== STRÄNGINFORMATION ===========
            // string.Length ger längden på strängen.
            var batman = "Batman";
            Console.WriteLine(batman.Length); // 6.
            // chararray[x]
            Console.WriteLine("Albus"[2] + "Dumbledore"[^2]); // ?!? 212, ska bara br

            // ======== PRINT STRINGINFORMATION ============
            var poem = @"Oh, promise me that someday you and I
 Will take our love together to some sky
 Where we can be alone and faith renew
 And find the hollows where those flowers grew
 Those first sweet violets of early spring
 Which come in whispers, thrill us both, and sing
 Of love unspeakable that is to be;
            Oh, promise me!Oh, promise me!
            -Scott, Clement and De Koven, Reginald";
            StringMetoderRepetition.PrintStringInformation(poem);
        }
    }

    internal static class StringMetoderRepetition
    {
        // TODO: Ta bort utropstecknet!
        public static string[] Words(this string text) // Words är en ext-metod.
        {
            string[] x = text.Split(' ');
            return x;
        }

        public static string Scramble(this string word)
        {
            Random randomiser = new Random();
            int times = 5;
            char[] chars = word.ToCharArray();
            for (int rounds = 0; rounds < times; rounds++)
            {
                for (int letter = 0; letter < chars.Length; letter++)
                {
                    int pos = randomiser.Next(0, word.Length);
                    var temp = chars[letter];
                    chars[letter] = word[pos];
                    chars[pos] = temp;
                }
            }
            return new string(chars);
        }

        public static string Left(this string text, int length)
        {
            string s = text.Substring(0, length);
            return s; // Super

            // return text.Substring(0, length); ALTERNATIVT
        }

        public static string Right(this string text, int length)
        {
            return text.Substring(text.Length - length); // man
        }

        public static string Initials(this string wholeName)
        {
            string[] splittedFullname = wholeName.Split(' ');
            string firstName = splittedFullname[0];
            string lastName = splittedFullname[1];
            string firstnameInitial = firstName.Substring(0, 1);
            string lastnameInitial = lastName.Substring(0, 1);
            string initials = firstnameInitial + lastnameInitial;
            return initials; // CG

            /* FACIT:
            var split = wholeName.Replace('-', ' ').Replace('.', ' ').Split(' ');
            var initals = "";
            foreach (var name in split)
            {
                initals += name[0];
            }

            return initals.ToUpper();
            */
        }

        public static string Add(this string text, int number)
        {
            int.TryParse(text, out int myNewNum);
            myNewNum += number;
            return myNewNum.ToString(); // 105 respektive 10

            // facit:
            var num = 0;
            var isNum = int.TryParse(text, out num); //out int num om den inte är dekl tidigare
            if (isNum)
            {
                return (num + number).ToString();
            }
            else
            {
                return text;
            }
        }

        public static int ToInt(this string text)
        {
            int.TryParse(text, out int num);
            //int num = int.Parse(text);
            //int num = Convert.ToInt32(text);
            return num;
        }

        // Vad betyder _?
        public static bool IsNumeric(this string text)
        {
            return int.TryParse(text, out _);
        }

        public static string BondGreeting(string name, string lastName)
        {
            //string m = ("My name is " + lastName + ", " + name + " " + lastName);
            // return m;

            // facit:
            return string.Format("My name is {1}, {0} {1}.", name, lastName);
        }

        // Vill ta bort ,
        public static void PrintStringInformation(string text)
        {
            string firstChar = text.Substring(0, 1);
            string lastChar = text.Substring(text.Length - 1);
            string[] allWords = text.Split(' ');
            string firstWord = allWords[0].Replace(',', ' '); // ?
            string lastWord = "";
            int numberOfWords = allWords.Length;
            int numberOfRows = 0;
            int numberOfCharacters = 0;

            Console.WriteLine(numberOfWords);
            Console.WriteLine(numberOfRows);
            Console.WriteLine(numberOfCharacters);
            Console.WriteLine(firstChar);
            Console.WriteLine(lastChar);
            Console.WriteLine(firstWord);
            Console.WriteLine(lastWord);

            // FACIT:
            var rows = 0;
            foreach (var letter in text)
            {
                if (letter == '\n') rows++;
            }

            var words = text.Words();
            var sb = new StringBuilder();
            sb.AppendLine($"Den består av {words.Length} ord och {rows} rader.");
            sb.AppendLine($"Den är {text.Length} tecken lång och börjar på '{text[0]}' och slutar med '{text[^1]}'.");
            sb.AppendLine($"Första ordet är '{words[0]}' och sista ordet är {words[^1]}'");
            Console.WriteLine(sb.ToString());
        }
    }
}
