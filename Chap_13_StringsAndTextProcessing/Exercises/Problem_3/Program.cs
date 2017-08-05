// Write a program that detects how many imtes a substring is contained in the text
// provided... display the count of detected items 

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string keyword = "in";
            
            int count = Regex.Matches(sampleText, keyword, RegexOptions.IgnoreCase).Count;
            Console.WriteLine(count); 
        }
    }
}