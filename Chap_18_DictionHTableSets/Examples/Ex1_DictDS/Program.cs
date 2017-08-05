using System;
using System.Collections.Generic;

namespace Ex1_DictDS
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleOne();
        }

        public static void ExampleOne()
        {
            IDictionary<string, double> studentMarks = new Dictionary<string, double>();
            studentMarks["Paul"] = 23.13;
            studentMarks["John"] = 43.23;
            Console.WriteLine("Paul's mark: {0:00.00}", studentMarks["Paul"]);
            Console.WriteLine("John's mark: {0:00.00}", studentMarks["John"]);
        }
    }
}