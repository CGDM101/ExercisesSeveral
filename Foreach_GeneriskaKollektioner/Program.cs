using System;
using System.Collections.Generic;

namespace Foreach_GeneriskaKollektioner
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRINT LIST
            PrintList(new List<string> { "Batman", "Robin", "Batgirl", "Alfred", "Ace", "Oracle", "Huntress" });

            // PRINT ARRAY (obs array är ej generisk så man kan inte lägga in vad man vill)
            PrintArray(new string[] { "Batman", "Robin", "Batgirl", "Alfred", "Ace", "Oracle", "Huntress" });

            // PRINT DICTIONARY
            var alias = new Dictionary<string, string>();
            alias.Add("Bruce Wayne", "Batman");
            alias.Add("Clark Kent", "Superman");
            alias.Add("Peter Quill", "Starlord");
            alias.Add("Groot", "Groot");
            PrintDictionary(alias);

            // TODO LIST QUEUE
            var myQueue = new Queue<string>(); // FIFO
            myQueue.Enqueue("9:00 Kolla mejlen");
            myQueue.Enqueue("9:30 Standup");
            myQueue.Enqueue("9:45 Kaffe"); 
            myQueue.Enqueue("10:00 Programmering");
            myQueue.Enqueue("11:15 Möte med kund");
            myQueue.Enqueue("12:00 Lunch");
            PrintQueue(myQueue);

            // TODO LIST STACK
            var myStack = new Stack<string>(); // LIFO
            myStack.Push("9:00 Kolla mejlen");
            myStack.Push("9:30 Standup");
            myStack.Push("9:45 Kaffe");
            myStack.Push("10:00 Programmering");
            myStack.Push("11:15 Möte med kund");
            myStack.Push("12:00 Lunch");
            PrintStack(myStack);
        }

        private static void PrintStack(Stack<string> myStack) // Läses upp baklänges.
        {
            // FACIT:
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop()); // ?
            }

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}
        }

        private static void PrintQueue(Queue<string> todoList)
        {
            // FACIT:
            while (todoList.Count > 0)
            {
                Console.WriteLine(todoList.Dequeue()); // ?
            }

            //foreach (var item in todolist)
            //{
            //    console.writeline(item);
            //}
        }

        public static void PrintList(List<string> namesList)
        {
            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintArray(string[] namesList)
        {
            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintDictionary(Dictionary<string,string> aliasList)
        {
            foreach (var item in aliasList)
            {
                Console.WriteLine(item.Key + " is " + item.Value);
                // Console.WriteLine(item); // [Groot, Groot]
            }
        }
    }
}
