using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Fun with Arrays:");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=>Simple Array Creation:");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            foreach(int i in myInts)
                Console.WriteLine(i);
            string[] booksOnDotNet = new string[4];
            booksOnDotNet[0] = "Hobbit the taken to Isengard!";
            booksOnDotNet[1] = "What you say?";
            booksOnDotNet[2] = "The power of morgul!";
            booksOnDotNet[3] = "Oops!200";
            foreach (string stripped in booksOnDotNet)
                Console.WriteLine(stripped);
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            string[] stringArray = new string[]
            {"one", "two", "three"};
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            bool[] boolArray = {false, false, true};
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            int[] intArray = new int[4] {20, 22, 23, 0};
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization:");
            var a = new[] {1, 10, 100, 1000};
            Console.WriteLine("a is a: {0}", a.ToString());
            var b = new[] {1, 1.5, 2, 2.5};
            Console.WriteLine("b is a: {0}", b.ToString());
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }
    }
}
