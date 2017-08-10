using System;
using System.Collections.Generic;

namespace ADT_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            // Queue Usage - Example
            Console.WriteLine("Basic Queue example");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Message One");
            queue.Enqueue("Message Two");
            queue.Enqueue("Message Three");
            queue.Enqueue("Message Four");

            while (queue.Count > 0)
            {
                string msg = queue.Dequeue();
                Console.WriteLine(msg);
            }

            Console.WriteLine();

            // Sequence N, N+1, 2*N - Example
            Console.WriteLine("Number Sequence Example");
            int n = 3;
            int p = 16;

            Queue<int> numSeq = new Queue<int>();
            numSeq.Enqueue(n);
            int index = 0;
            Console.Write("S =");
            while (numSeq.Count > 0)
            {
                index++;
                int current = numSeq.Dequeue();
                Console.Write(" " + current);
                if (current == p)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    return;
                }
                numSeq.Enqueue(current + 1);
                numSeq.Enqueue(2 * current);
            }
        }
    }
}