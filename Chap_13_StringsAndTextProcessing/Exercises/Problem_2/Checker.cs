using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_Two
{
    class Checker
    {
        public static void CheckAlgoParenthesis(string algo)
        {
            // removes all chars except the pars
            string newAlgo = Regex.Replace(algo, "[^()]", string.Empty);

            if (newAlgo.Length % 2 == 0)
            {
                Console.WriteLine("The algorithm is balanced!");
            }
            else if (newAlgo.Length % 2 == 1)
            {
                Console.WriteLine("The algorithm is not balanced!");
            }

            // determine count of remaining chars
                // if %2 returns 1, return "not balanced"
                // if %2 returns 0, return "balanced" 


        }
    }
}
