using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_One
{
    class StringManip
    {

        public static string ReverseString(string str)
        {
            StringBuilder strReverse = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strReverse.Append(str[i]);
            }

            return strReverse.ToString();
        }
    }
}
