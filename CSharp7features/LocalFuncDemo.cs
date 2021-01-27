using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7features
{
    class LocalFuncDemo
    {
        public static void Main1()
        {
            // Local function supports Params, ref, out and generics 


            void MyLocalFunc()
            {
                Console.WriteLine("This is my local function");
            }

            void add(int i,int j, ref int g, ref int k)
            {
                g = 100;
                k = 200;
                Console.WriteLine("Addition of {0} {1} is " + (i + j), i, j);
            }
            MyLocalFunc();
            int j=2, k =10;
            add(3, 4, ref j, ref k);
            Console.WriteLine(j + " " + k);
            
            

        }
    }
}
