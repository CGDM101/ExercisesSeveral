using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            // PARSE
            // Gör om till lämplig numerisk typ:
            string str = "15,42"; // Varför funkar inte '15.42'?
            double d = double.Parse(str);

            string strr = "1337";
            int i = int.Parse(strr);

            string st = "katt";
            // ?

            // TRYPARSE
            string myStr = "15,42"; // Punkt funkar inte.
            double a;
            bool res = double.TryParse(myStr, out a);
            Console.WriteLine("This string is a numeric representation:" + res); // true

            string x = "1337";
            int aa;
            bool result = int.TryParse(x, out aa);
            Console.WriteLine("This string is a numeric representation:" + result); // true

            string y = "katt";
            int z;
            bool r = int.TryParse(y, out z);
            Console.WriteLine("Is numeric repr: " + r);
            // ?
        }
    }
}
