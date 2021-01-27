using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7features
{
    class BinaryLiteralsAndDigitSeparators
    {
        public static void Main1()
        {
            int i = 0b101001;
            Console.WriteLine(Convert.ToChar(i));

            long l = 10_00_00_000;
            Console.WriteLine(l);

            Console.ReadLine();
        }
    }
}
