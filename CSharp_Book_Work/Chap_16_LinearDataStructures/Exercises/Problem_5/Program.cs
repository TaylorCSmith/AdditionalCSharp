// Write a program, which removes all negative numbers from a sequence

using System;
using System.Collections.Generic;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveNegNumbers.FillList();

            List<int> result = new List<int>();

            result = RemoveNegNumbers.FilterAndSum();
            RemoveNegNumbers.PrintGivenList(result);
        }
    }
}