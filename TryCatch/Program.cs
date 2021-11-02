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

            // =============

            Person person = null;
            try
            {
                person.Name = "Jack Sparrow";
            }
            // Triggas av null error:
            catch (System.NullReferenceException ex)
            {
                Console.WriteLine(ex.Message); // Hantera vad som gått fel.
            }
            // Triggas av alla andra error:
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Ifall minnet behöver städas upp:
            finally
            {
                person = null;
            }
        }
    }

    class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Ha minimalt med kod i Try Catch, för att lätt identifiera vad som gått fel. Hellre flera Try Catch efter varandra.
    // Try Catch är långsammare än if-satser.
}
