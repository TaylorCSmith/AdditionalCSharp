using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    class SortList
    {
        List<int> numList = new List<int>(); 

        public void FillList()
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

        public void SortIntegerList()
        {
            numList.Sort();
        }

        public void PrintList()
        {
            numList.ForEach(Console.WriteLine);
        }

    }
}
