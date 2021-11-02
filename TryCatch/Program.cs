using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // TRY.
            // CATCH. Fånga upp kraschmeddelandet. Logga meddelandet.
            // FINALLY. Förstör objektet och annat som kan skapa minnesläckor.

            //int x = 1 / 0; // Kompilerar inte - "Division by constant zero"

            try
            {
                int num1 = 4;
                int num2 = 0;
                int x = num1 / num2; // Kraschar inte, utan går in i Catch.
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }
    }
}
