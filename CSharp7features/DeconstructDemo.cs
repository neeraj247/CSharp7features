using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7features
{
    public class employee
    {
        int _E_no;
        string _strName;
        string _designation;
        public employee(int e_no, string strName, string designation)
        {
            _E_no = e_no;
            _strName = strName;
            _designation = designation;
        }

        public void Deconstruct(out int e_no, out string strName, out string designation)
        {
             e_no = _E_no;
             strName = _strName;
             designation = _designation;
        }
    }
    class DeconstructDemo
    {
        public static void Main1()
        {
            employee emp = new employee(1001, "Neeraj", "Architect") { };

            // C# 7 feature
            var (i, j, k) = emp;
            Console.WriteLine("Values are {0} {1} {2}", i, j, k);

            var (a,_,_) = emp;
            Console.WriteLine("Value is {0}", a);

            Console.ReadLine();
        }
    }
}
