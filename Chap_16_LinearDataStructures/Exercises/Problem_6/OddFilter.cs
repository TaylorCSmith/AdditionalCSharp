using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_6
{
    class OddFilter
    {
        public static List<int> numList = new List<int>();

        public static void CreateList()
        {
            Console.WriteLine("Please enter positive integers (Press ENTER when done): ");
            while (true)
            {
                string inputNumber = Console.ReadLine();
                if (string.Equals(inputNumber, string.Empty))
                { 
                    break;
                }
                else
                {
                    numList.Add(int.Parse(inputNumber));
                }
            }
        }

        public static List<int> FilterList()
        {
            List<int> result = new List<int>();
            

            for (int i = 0; i < numList.Count; i++)
            {
                int numCount = 0;

                for (int j = 0; j < numList.Count; j++)
                {
                    if (numList[i] == numList[j])
                    {
                        numCount += 1; 
                    }
                }

                if (numCount % 2 == 0)
                {
                    result.Add(numList[i]);
                }
            }
            return result; 
        }

        public static void PrintList(List<int> list)
        {
            list.ForEach(Console.WriteLine);
        }

    }
}
