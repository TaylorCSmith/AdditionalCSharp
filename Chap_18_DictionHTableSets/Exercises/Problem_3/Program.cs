// Write a program that counts how many times each word from a given text file words.txt appears in it
// the result words should be ordered by their number of occurences

using System;
using System.IO; // for reading from the text file
using System.Collections.Generic; // used for creating the dictionary
using System.Linq; // used for sorting the dictionary

namespace Problem_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = ReadTextFromFile();
            IDictionary<string, int> dictionary = InsertStringIntoDictionary(text);

            SortAndPrintByCount(dictionary);
        }

        // write method that extracts string from .txt

        private static string ReadTextFromFile()
        {
            FileStream stream = new FileStream(@"C:\Users\Taylo\Desktop\C# Practice\Chap_18_DictionHTableSets\Exercises\Problem_3\Sample.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string text;

            using (reader)
            {
                text = reader.ReadLine(); 
            }
            return text;
        }

        // write method that inserts words into Dictionary
        //  - use string.split to insert words into string[] (regex for pattern?)
        //  - insert string array into dictionary (will be sorted later so doesn't need to be a SortedDictionary)

        private static IDictionary<string, int> InsertStringIntoDictionary(string text)
        {
            string[] textArr = text.Split(' ', ',', '.', '-', '!', '?', ':', ';');
            IDictionary<string, int> textDict = new SortedDictionary<string, int>(new CaseInsensitiveComparer());

            foreach (var item in textArr)
            {
                if (!string.IsNullOrWhiteSpace(item.Trim()))
                {
                    int count;
                    if (!textDict.TryGetValue(item, out count))
                    {
                        count = 0;
                    }
                    textDict[item] = count + 1;
                }
            }
            return textDict;
        }

        // method to get InsertStrintIntoDictionary to ignore word casing
        class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string s1, string s2)
            {
                return string.Compare(s1, s2, true);
            }
        }


        // method to sort dictionary by value and print
        //  - just use LINQ (p => p.Value)

        private static void SortAndPrintByCount(IDictionary<string, int> textDiction)
        {
            var textDictionTwo = textDiction.OrderBy(p => p.Value);
            foreach(var item in textDictionTwo)
            {
                Console.WriteLine("{0} --> {1}", item.Key, item.Value);
            }
        }
    }
}