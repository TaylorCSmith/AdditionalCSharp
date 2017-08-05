using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    class ReverseOrder
    {
        private static Stack<int> problemTwoStack = new Stack<int>();

        public void FillStack()
        {
            Console.Write("Enter in the number of integers you will enter: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your integers: ");
            for (int i = 0; i < N; i++)
            {
                problemTwoStack.Push(int.Parse(Console.ReadLine())); 
            }
        }

        public void PrintStackReverse()
        {
            Console.Write("Here's your integers reversed:");

            while (problemTwoStack.Count != 0)
            {
                Console.Write(" " + problemTwoStack.Pop());
            }

            Console.WriteLine(); 

        }

    }
}
