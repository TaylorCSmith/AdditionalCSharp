using System;
using System.Text.RegularExpressions;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";


            string output = UpperMatch(text);
            Console.WriteLine(output);
        }

        public static string UpperMatch(string s)
        {
            string pattern = " ";

            return Regex.Replace(s, "<upcase> ", delegate (Match match)
            {
                string v = match.ToString();
                return v.ToUpper(); 
            });



        }
    }
}