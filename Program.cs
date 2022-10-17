using System;
using System.Collections.Generic;
/*
Question:
Write a program which accepts a sequence of comma-separated numbers from console and generate a list and a tuple which contains every number.
Suppose the following input is supplied to the program:
34,67,55,33,12,98
Then, the output should be:
['34', '67', '55', '33', '12', '98']
('34', '67', '55', '33', '12', '98')
*/
namespace c_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide 6 numbers seperated by space:");
            var line = Console.ReadLine().Split(",");
            var num1 = int.Parse(line[0]);
            var num2 = int.Parse(line[1]);
            var num3 = int.Parse(line[2]); 
            var num4 = int.Parse(line[3]); 
            var num5 = int.Parse(line[4]); 
            var num6 = int.Parse(line[5]); 
            var num7 = (num1, num2, num3, num4, num5, num6);
            Console.WriteLine(num7);
            Console.WriteLine("[" + num7 + "]");
            //Console.WriteLine("(" + "{0} {1}" ,num1,  num2 );
            //Tuple<> tuple = line;
            //Console.WriteLine(tuple);
            //Console.WriteLine(list);
        }
    }
}
