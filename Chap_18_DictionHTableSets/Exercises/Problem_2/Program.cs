// Write a program to remove from a sequence all the integers which appear odd number of times... 

using System;
using System.Collections.Generic;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 5, 2, 4, 35, 3, 2, 3, 5, 2, 3, 5, 4, 6, 2, 3, 4, 5, 2, 3, 16, 16 };

            SortedDictionary<int, int> dictionary = GetIntegerCount(arr);
            dictionary = RemoveEvenIntegers(dictionary);
            PrintAllKeys(dictionary);
        }

        private static SortedDictionary<int, int> GetIntegerCount(int[] arr)
        {
            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();

            foreach(int item in arr)
            {
                int count;
                if (!dictionary.TryGetValue(item, out count)) {
                    count = 0;
                }
                dictionary[item] = count + 1; 
            }
            return dictionary;
        }

        private static SortedDictionary<int, int> RemoveEvenIntegers(SortedDictionary<int, int> dictionary)
        {
            SortedDictionary<int, int> dictionaryTwo = new SortedDictionary<int, int>(); 

            foreach(var item in dictionary)
            {
                if (item.Value % 2 == 1)
                {
                    dictionaryTwo.Add(item.Key, item.Value);
                }
            }
            return dictionaryTwo;
        }

        private static void PrintAllKeys(SortedDictionary<int, int> dictionary)
        {
            foreach(var items in dictionary)
            {
                Console.WriteLine("{0} ", items.Key);
            }
        }
    }
}