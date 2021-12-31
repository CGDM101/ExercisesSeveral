using System;

namespace PropertiesAndInheritance
{
    public class MagicNumber
    {
        public int Value { get; set; }
    }
    public class MyClass // WIP
    {
        private int namn;

        public int Namn
        {
            get 
            {
                return namn;
            }
            set
            {
                // I set skriver du ut variabeln och sedan "har ändrats till " och slutligen skrive rdu ut value. Sätt variablen till att bli value.
                Console.WriteLine(namn + "har ändrats till " + value);
                namn = value;
            }
        }
        public bool IsAlive { get; set; } = true; // true som standard
        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Properties-övningen:     


            // Arvövningen:
            Pitbull pb = new Pitbull { Name = "Fido", Age = 5, Playful = true };
            Poodle p = new Poodle { Name = "Karo", Age = 2, Barking = true }; // Kan inte sätta playful eftersom det bara finns i Pitbull!
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
    }

    public class Pitbull : Dog
    {
        public bool Playful { get; set; }
    }

    public class Poodle : Dog
    {
        public bool Barking { get; set; }
    }
}
