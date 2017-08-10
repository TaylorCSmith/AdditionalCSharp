// Write a program that removes from a iven sequence all numbers that appear an odd count of times

using System;
using System.Collections.Generic;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            OddFilter.CreateList();
            List<int> result = OddFilter.FilterList();
            OddFilter.PrintList(result);

        }
    }
}