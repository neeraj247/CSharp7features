using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7features
{
    class refKeywordImproved
    {
        public static ref string getColor(int i, string[] colors)
        {
            return ref colors[i];
        }
        public static void Main()
        {
            // Ref locals 
            string[] colors = { "Red", "Yellow", "Black", "White", "Brown" };
            ref string color = ref colors[2];
            Console.WriteLine(String.Join("  ", colors));
            Console.WriteLine("Color was " + color);
            color = "Green";
            Console.WriteLine("Color is " + color);
            Console.WriteLine(String.Join("  ", colors));


            //ref returns
            string[] Colors = { "Red", "Yellow", "Black", "White", "Brown" };
            ref string Color = ref getColor(3, Colors);
            Console.WriteLine(String.Join("  ", Colors));
            Console.WriteLine("Color was " + Color);
            Color = "Green";
            Console.WriteLine("Color is " + Color);
            Console.WriteLine(String.Join("  ", Colors));


            Console.ReadLine();
        }
    }
}
