// Write a program that reads a string, reverses it, and prints it to the console.

using System;

namespace Problem_One
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "\"Hello User, welcome to the program\"";

            string olleh = StringManip.ReverseString(hello);
            Console.WriteLine(hello + " reversed is " + olleh);
            
        }
    }
}