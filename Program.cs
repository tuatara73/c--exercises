using System;
using System.Collections.Generic;
/*
Question:
Write a program that calculates and prints the value according to the given formula:
Q = Square root of [(2 * C * D)/H]
Following are the fixed values of C and H:
C is 50. H is 30.
D is the variable whose values should be input to your program in a comma-separated sequence.
Example
Let us assume the following comma separated input sequence is given to the program:
100,150,180
The output of the program should be:
18,22,24
*/
namespace c_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int C, H;
            C = 50;
            H = 30;
            string[] F = Console.ReadLine().Split(" ");
            //int D = Convert.ToInt32(F);
            //Console.WriteLine(D);
            foreach(int i in F)
            {
                Console.WriteLine((2 * C * i)/H);
            }
        }
    }
}

