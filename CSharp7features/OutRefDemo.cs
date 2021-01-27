using System;

namespace CSharp7features
{
    class OutRefDemo
    {
        public static void OutParamtest(out int i, out int j)
        {
            i = 10;
            j = 15;
        }
        static void Main1(string[] args)
        {
            OutParamtest(out int i, out int j);
            Console.WriteLine("I is {0}, J is {1}", i, j);

            Console.ReadLine();
        }
    }
}
