using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8
{
    class MajorantFinder
    {
        public static int[] numbers = { 4, 2, 4, 4, 6, 2, 4, 4, 4, 4, 4, 5, 5, 4 };

        // probably not the best way of doing this program... 
        public static List<int> numCountList = new List<int>(new int[20]);
        public static int majorant = 0;
        
        public static void FindMajorant()
        {
            int numberCount = numbers.Length;
            majorant = (numberCount / 2) + 1; 
        }

        public static void FilterList()
        {
            for(int item = 0; item < numbers.Length - 1; item++)
            {
                int number = numbers[item];
                numCountList[number] += 1; 
            }
            for (int i = 0; i < numCountList.Count; i++)
            {
                if (numCountList[i] >= majorant)
                {
                    Console.WriteLine(i + " is a majorant");
                }
                else if (numCountList[i] < majorant && numCountList[i] != 0)
                {
                    Console.WriteLine(i + " is not a majorant!"); 
                }
            }
        }
    }
}
