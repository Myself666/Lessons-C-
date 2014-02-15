using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Fun with Methods********\n");
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            int i;
            string str;
            bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Bool is: {0}", b);
            string s1 = "flip";
            string s2 = "flop";
            Console.WriteLine("Before: {0}, {1}", s1, s2);
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0}, {1}", s1, s2);
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);
            double[] data = {4.0, 3.2, 5.7};
            average = CalculateAverage(data);
            Console.WriteLine("Average of data: {0}", average);
            double average1;
            average1 = CalculateAverage(3.0, 3.0, 3.0);
            Console.WriteLine("Average data is: {0}", average1);
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I Can't find the payroll data", "CFO");
            DisplayFancyMessage(message: "Wow! Vert Fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
                message: "Testing...",
                textColor: ConsoleColor.DarkBlue);
            Console.ReadLine();
        }

        public static void Add(int x, int y,out int ans)
        {
            ans = x + y;
        }

        public static void FillTheseValues(out int a, out string b, out bool e)
        {
            a = 9;
            b = "Enjoy your string!";
            e = true;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum/values.Length);
        }
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue, 
            ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}
