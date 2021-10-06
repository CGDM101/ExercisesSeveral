using System;

namespace _14MagiskaEnums
{
    interface IOutput
    {
        void Write(string text); // Skriv i bufferten (utan ny rad)
        void WriteLine(string text); // Skriv i bufferten (med ny rad)
    }
    public enum Race
    {
        Wizard,
        Elf,
        Human,
        Furby,
        Muppet,
        Zombie
    }
    public enum Weapon
    {
        Sword,
        Staff,
        Knife,
        StilettoHeels,
        RubberDuck
    }
    class Game
    {
        public Player Player { get; set; }
        /// <summary>
        /// Slumpar fram värden till alla props
        /// </summary>
        public void GenerateRandomPlayer() 
        {
            Random random = new Random();
        }
        /// <summary>
        /// Skriver ut spelarens stats
        /// </summary>
        public void ShowPlayer()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
