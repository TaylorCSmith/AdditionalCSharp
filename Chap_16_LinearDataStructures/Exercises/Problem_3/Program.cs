// Write a program that reads from the console a sequence of positive integer numbers.The sequence 
// ends when an empty line is entered.Print the sequence sorted in ascending order.

using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortList listOne = new SortList();

            listOne.FillList();
            listOne.SortIntegerList();

            Console.WriteLine(); 
            listOne.PrintList();
        }
    }
}