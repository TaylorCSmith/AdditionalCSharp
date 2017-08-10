using System;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            // ********************* example one *********************

            // SimpleExample.ExampleOne();

            // ********************* example two *********************

            string score = "sCore";
            string scary = "scary";
            SimpleExample.LexiCompareTo(score, scary);
            SimpleExample.LexiCompareTo(scary, score);
            SimpleExample.LexiCompareTo(scary, scary);

            // ********************* example three *********************
            Console.WriteLine();

            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";

            SimpleExample.OverLexiCompare(alpha, score1, false);
            SimpleExample.OverLexiCompare(score1, score2, false);
            SimpleExample.OverLexiCompare(score1, score2, true);
            Console.WriteLine(string.Compare(score1, score2, StringComparison.CurrentCultureIgnoreCase));

            // ********************* example three *********************
            // Fine all occurrences of a substring

            Console.WriteLine();

            string quote = "The main intent of the \"Intro C#\"" + " book is to introduce C# programming to noobs.";
            string keyword = "C#";

            SimpleExample.SearchSubStringOcc(quote, keyword);

            // ********************* example four *********************
            // usage of regular expressions.

            Console.WriteLine();

            SimpleExample.RegexExample();

            // ********************* example five *********************
            // usage of StringBuilder

            Console.WriteLine();

            SimpleExample.StrBuilderEx();

            // ********************* example six *********************
            // reverse a string using StringBuilder

            Console.WriteLine(); 

            string text = "EM edit";
            string reversed = SimpleExample.ReverseText(text);
            Console.WriteLine(reversed);
        }
    }
}