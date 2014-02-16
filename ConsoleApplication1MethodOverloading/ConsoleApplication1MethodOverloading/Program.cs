using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with Overloading Methods:");
            Console.WriteLine(Add(10, 10));
            Console.WriteLine(Add(90000000000000000, 9000000000000000));
            Console.WriteLine(Add(2.5, 4.3));
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }

        static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
