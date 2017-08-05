using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7
{
    class Occurances
    {
        private static int[] numbers = { 1, 3, 2, 5, 6, 3, 2, 1, 5, 2, 3, 5, 3, 2, 2 };
        public static List<int> numList = new List<int>(numbers);

        private static int[] numOccurance = new int[1001];
        

        public static void FindOccurances()
        {
            for (int i = 0; i < numList.Count; i++)
            {
                int number = numList[i];
                numOccurance[number]++;
            }
        }

        public static void PrintList()
        {
            Console.WriteLine("These numbers appear this many times: ");
            for (int i = 0; i < numOccurance.Length - 1; i ++)
            {
                if (numOccurance[i] != 0)
                {
                    Console.WriteLine(i + " -> " + numOccurance[i]);
                }
            }
        }

    }
}
