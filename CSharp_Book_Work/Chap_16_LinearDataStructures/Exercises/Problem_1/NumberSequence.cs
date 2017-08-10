using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1
{
    class NumberSequence
    {
        private static List<int> numList = new List<int>();

        public static void FillList()
        {
            Console.WriteLine("Please enter positive integers (Press ENTER when done): ");
            while (true)
            {
                string inputNumber = Console.ReadLine();
                if (string.Equals(inputNumber, string.Empty))
                { 
                    break;
                }
                else if (int.Parse(inputNumber) < 0)
                {
                    Console.WriteLine("Number must be a positive integer");
                }
                else
                {
                    numList.Add(int.Parse(inputNumber));
                }
            }
        }

        public static double Average()
        {
            double sum = 0;
            foreach (var item in numList)
            {
                sum += item;
            }

            double average = (sum/numList.Count);

            return average; 
        }
    }
}
