using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IterationAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForAndForEachLoop();
            VarInForeachLoop();
            ExecuteWhileLoop();
            ExecuteDoWhileLoop();
            ExecuteSwitch();
            Console.ReadLine();
            
        }

        static void ForAndForEachLoop()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number us: {0}", i);
            }
            string[] carTypes = {"Ford", "BMW", "Yogu", "Honda"};
            foreach (string c in carTypes)
                Console.WriteLine(c);
            int[] myInts = {10, 20, 30, 40};
            foreach (int i in myInts)
                Console.WriteLine(i);
        }

        static void VarInForeachLoop()
        {
            int[] myInts = {10, 20, 30, 40};
            foreach (var item in myInts)
            {
                Console.WriteLine("Item value: {0}", item);
            }
        }

        static void ExecuteWhileLoop()
        {
            string userIsDone = "";
            while (userIsDone.ToLower() != "yes")
            {
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("In while loop");
            }
        }

        static void ExecuteDoWhileLoop()
        {
            string userIsDone = "";
            do
            {
               Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");
        }

        static void ExecuteSwitch()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference:");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1: Console.WriteLine("Good choice, C# is cool language");
                    break;
                case 2: Console.WriteLine("VS: OOP, multithreading and more!");
                    break;
                default: Console.WriteLine("Well... good luck with that!");
                    break;
            }
        }
    }
}
