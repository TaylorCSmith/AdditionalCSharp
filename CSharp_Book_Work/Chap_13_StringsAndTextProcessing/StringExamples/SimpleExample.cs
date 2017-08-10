using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringExamples
{
    class SimpleExample
    {
        public static void ExampleOne ()
        {
            string message = "This is a sample string message.";

            Console.WriteLine("message = {0}", message);
            Console.WriteLine("message.Length = {0}", message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("message[{0}] = {1}", i, message[i]);
            }
        }

        public static void LexiCompareTo(string a, string b)
        {
            Console.WriteLine(a.CompareTo(b));
        }

        public static void OverLexiCompare(string a, string b, bool c)
        {
            Console.WriteLine(string.Compare(a, b, c)); 
        }

        public static void SearchSubStringOcc(string str, string subStr)
        {
            int index = str.IndexOf(subStr);

            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", subStr, index);
                index = str.IndexOf(subStr, index + 1);
            }
        }

        public static void RegexExample()
        {
            string doc = "Smith's number: 0898880022 \nFranky cn be found at 0888445566. \nSteven's mobile number: 0887654321";
            string replacedDoc = Regex.Replace(doc, "(08)[0-9]{8}", "$1********");
            Console.WriteLine(replacedDoc);
        }

        public static void StrBuilderEx()
        {
            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");

            for (int i = 0; i <= 200000; i++)
            {
                sb.Append(i);
            }

            Console.WriteLine(sb.ToString().Substring(0, 1024));
            Console.WriteLine(DateTime.Now);
        }

        public static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }
    }
}
