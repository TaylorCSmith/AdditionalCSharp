using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{
    class RemoveNegNumbers
    {
        public static List<int> numList = new List<int>();

        public static void FillList()
        {
            Console.WriteLine("Please enter positive integers (Press ENTER when done... include some negatives): ");
            while (true)
            {
                string inputNumber = Console.ReadLine();

                if (string.Equals(inputNumber, string.Empty))
                {
                    break;
                }

                numList.Add(int.Parse(inputNumber));
            }
        }

        public static List<int> FilterAndSum()
        {
            List<int> result = new List<int>(); 

            foreach(int item in numList)
            {
                if (item > 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static void PrintGivenList(List<int> list)
        {
            list.ForEach(Console.WriteLine);
        }




    }
}
