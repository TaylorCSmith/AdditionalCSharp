// Write a program that reads from the console a sequence of positive integer numbers.The sequence ends when empty line is entered. 
// Calculate and print the sum and the average of the sequence.Keep the sequence in List<int>.

using System;
using System.Collections.Generic;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberSequence.FillList();
            Console.WriteLine("The average is: " + NumberSequence.Average());
            
        }
    }
}