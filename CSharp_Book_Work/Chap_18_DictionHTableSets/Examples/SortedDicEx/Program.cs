using System;
using System.Collections.Generic;

namespace SortedDicEx
{
    class Program
    {

        private static readonly string Text =
            "Mary had a little lamb " +
            "little Lamb, little Lamb, " +
            "Mary had a Little lamb, " +
            "whose fleece were white as snow.";

        static void Main(string[] args)
        {
            IDictionary<string, int> map = GetWordOccurenceMap(Text);
            PrintWordOccurenceCount(map);
        }

        private static IDictionary<string, int> GetWordOccurenceMap(string text)
        {
            string[] tokens = text.Split(' ', '.', ',', '-', '?', '!');

            IDictionary<string, int> words = new SortedDictionary<string, int>(new CaseInsensitiveComparer());

            foreach (string word in tokens)
            {
                if (!string.IsNullOrEmpty(word.Trim()))
                {
                    int count;
                    if (!words.TryGetValue(word, out count))
                    {
                        count = 0;
                    }
                    words[word] = count + 1;
                }
            }
            return words;
        }

        private static void PrintWordOccurenceCount(IDictionary<string, int> wordOccuranceMap)
        {
            foreach (var wordEntry in wordOccuranceMap)
            {
                Console.WriteLine("Word '{0}' occures {1} time(s) in the text", wordEntry.Key, wordEntry.Value);
            }
        }

        class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string s1, string s2)
            {
                return string.Compare(s1, s2, true); 
            }
        }
    }
}