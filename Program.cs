using System;
using System.Collections.Generic;
/*
Question:
Define a class which has at least two methods:
getString: to get a string from console input
printString: to print the string in upper case.
Also please include simple test function to test the class methods.
*/
namespace c_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            printString();
        }
        static string getString(string x)
        {
            var x = Console.ReadLine();
            return x;
        }
        static string printString()
        {
            getString();
            var z = x.ToUpper();
            return z;
        }
        }
    }
}
