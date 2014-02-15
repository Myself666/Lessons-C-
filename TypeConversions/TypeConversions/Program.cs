using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TypeConversions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("******* Fun with type conversions ******");
            short numb1 = 30000, numb2 = 30000;
            unchecked
            {
              short answer = (short) Add(numb1, numb2);
              Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);  
            }
            
            NarrowingAttemp();
            ProcessBytes();
            NarrowWithConvert();
            Console.ReadLine();
        }

        static int Add(int x, int y)
        { return x + y; }

        static void NarrowingAttemp()
        {
            Byte myByte = 0;
            int myInt = 200;
            myByte = (byte) myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            unchecked
            {
              byte sum = (byte) Add(b1, b2);
              Console.WriteLine("sum = {0}", sum);  
            }
            
        }

        static void NarrowWithConvert()
        {
            byte myByte = 0;
            int myInt = 200;
            myByte = Convert.ToByte(myInt);
            Console.WriteLine("Value of myByte: {0}", myByte);
        }


    }

}
