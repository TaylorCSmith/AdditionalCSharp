using System;
using System.Collections.Generic; 

namespace ADT_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack usage example
            Stack<string> stack = new Stack<string>();

            stack.Push("1. John Jackson");
            stack.Push("2. Nicolas Cage");
            stack.Push("3. Marry Poppins");
            stack.Push("4. Daniel Sadcliff");

            Console.WriteLine("Top = " + stack.Peek());
            while (stack.Count > 0)
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }

            Console.WriteLine();

            // Correct brackets check
            string expression = "1 + ( 3 + 2 - (2+3)*4 - ((3+1*(4-2)))";
            Stack<int> bracketStack = new Stack<int>();
            bool correctBrackets = true;

            for (int index = 0; index < expression.Length; index++)
            {
                char ch = expression[index];
                if (ch == '(')
                {
                    bracketStack.Push(index);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                correctBrackets = false;
            }

            Console.WriteLine("Are the brackets correct? " + correctBrackets);
        }
    }
}