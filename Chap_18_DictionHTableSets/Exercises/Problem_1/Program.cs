// Write a program that counts, in a given array of integers, the number of occurences of each integer

using System;
using System.Collections.Generic;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 4, 4, 1, 3, 4, 1, 3, 4, 5, 1, 4, 6, 8, 6, 7, 4 };

            IDictionary<int, int> dictionary = CountIntegers(arr);
            PrintIntegerOccuranceCount(dictionary);
        }

        private static IDictionary<int, int> CountIntegers(int[] arr)
        {

            IDictionary<int, int> intDict = new Dictionary<int, int>();
            
            foreach (int i in arr)
            {
                int count;
                if (!intDict.TryGetValue(i, out count))
                {
                    count = 0;
                }

                intDict[i] = count + 1; 
            }

            return intDict;

            // create a new dictionary with key int and value int...

            // iterate through the array "arr", if the key exists, add +1 to the value of that key...

            // if the key doesn't exist... create a new key and set its value to 0

            // return the dictionary
        }

        private static void PrintIntegerOccuranceCount(IDictionary<int, int> intDict)
        {
            foreach( var intEntry in intDict)
            {
                Console.WriteLine("{0} --> {1}", intEntry.Key, intEntry.Value);
            }
        }
    }
}