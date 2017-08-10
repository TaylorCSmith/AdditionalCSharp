// Write a program which reads from the console N integers and prints them in reersed order. Use the Stack<int> class.

using System;
using System.Collections.Generic;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseOrder order = new ReverseOrder();

            order.FillStack();
            order.PrintStackReverse();

            
        }
    }
}