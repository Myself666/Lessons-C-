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
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();
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

        static void ArrayOfObjects()
        {
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(2014, 2, 17);
            myObjects[3] = "Form and Void";
            foreach (object obj in myObjects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array:");
            int[,] myMatrix;
            myMatrix = new int[6, 6];
            for(int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i*j;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array:");
            int [] [] myJagArray = new int[5][];
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = {"Hello", "from", "GetStringArray"};
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            int[] ages = {20, 22, 23, 0};
            PrintArray(ages);
            string[] strs = GetStringArray();
            foreach(string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("Working with System.Array.");
            string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sisters of Mercy"};
            Console.WriteLine("-> Here is the Array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }

    }   
}
