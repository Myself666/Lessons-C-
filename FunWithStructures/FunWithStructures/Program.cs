using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********A First Look at Sctructures**************");
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            myPoint.Increment();
            myPoint.Display();
            Point p2 = new Point(50, 60);
            p2.Display();
            Console.ReadLine();
        }

        struct Point
        {
            public int X;
            public int Y;

            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
            public void Increment()
            {
                X++;
                Y++;
            }

            public void Decrement()
            {
                X--;
                Y--;
            }

            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }
        }
    }
}
