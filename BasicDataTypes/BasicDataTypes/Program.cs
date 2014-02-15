using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Numerics;

namespace BasicDataTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LocalVarDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            UseDatesAndTimes();
            UseBigInteger();
            Console.ReadLine();
        }

        private static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;
            string myString;
            myString = "This is my character data";
            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;
            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5},", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            Console.WriteLine("{0}, {1}, {2}", b, i, d);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine(" => System.Object Functionality:");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine(" => Data type functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there'), 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        private static void UseDatesAndTimes()
        {
            Console.WriteLine(" => Dates and Times:");
            DateTime dt = new DateTime(2014, 02, 07);
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use Big Integer:");
            BigInteger biggy = BigInteger.Parse("111111111111111111111111111111111");
            Console.WriteLine("Крупненький интеджер у нас {0}", biggy);
            Console.WriteLine("Крупненький у нас четный?: {0}", biggy.IsEven);
            Console.WriteLine("Крупненький являеться степенью двойки?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Parse("3333333333333333333333333333333333333");
            Console.WriteLine("Чуть крупнее интеджер у нас {0}", reallyBig);
            BigInteger reallyBig2 = biggy*reallyBig;
            Console.WriteLine("Очень крупный интеджер у нас:  {0}", reallyBig2);
        }
}
}
