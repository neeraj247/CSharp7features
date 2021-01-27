using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7features
{
    
    public class TupleDemo
    {
        public static (int, int) GetTupleValue(int i, int j)
        {
            return ((i + j), (i * j));
        }

        public static Tuple<int, int, string> GetValues()
        {
            Tuple<int, int, string> t = Tuple.Create(2, 3, "d");
            return t;
        }
        public static void Main1(string[] args)
        {
            var TupleItems = GetValues();
            Console.WriteLine("Tuple items are {0}  {1}  {2}", TupleItems.Item1, TupleItems.Item2, TupleItems.Item3);

            // C# 7 onwards
            var result = GetTupleValue(3, 4);
            (int a, int b) = GetTupleValue(13, 14);
            Console.WriteLine("Addition is {0} and Multiplication is {1}", result.Item1, result.Item2);
            Console.WriteLine("Addition of (13, 14) is {0} and Multiplication of (13, 14) is {1}", a, b);
            Console.ReadLine();

        }
    }
}
