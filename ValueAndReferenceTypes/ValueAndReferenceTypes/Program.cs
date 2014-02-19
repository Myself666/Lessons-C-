using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        { 
            ValueTypesAssignment();
            ReferenceTypeAssignment();
            Console.ReadLine();
        }

        static void ValueTypesAssignment()
        {
            Console.WriteLine(" Assigning value types\n");
            Point p1 = new Point(10, 10);
            Point p2 = p1;
            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
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
            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;
            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }


    }

    class PointRef
    {
        public int X;
        public int Y;
        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
