using System;
using System.Collections.Generic;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {

            #region example1
            //IDictionary<string, double> studentGrades = new Dictionary<string, double>(10);

            //studentGrades["Johnny"] = 3.00;
            //studentGrades["Billy"] = 4.00;
            //studentGrades["Jimmy"] = 2.50;
            //studentGrades["Bobby"] = 1.00;
            //studentGrades["Timmy"] = 5.2;
            //studentGrades["Louis"] = 3.8;
            //studentGrades["Debbie"] = 3.00;
            //studentGrades["Austin"] = 4.00;
            //studentGrades["Lenny"] = 2.50;
            //studentGrades["Xavier"] = 1.00;

            //double johnnysGrade = studentGrades["Johnny"];
            //Console.WriteLine("Johnny's grade: {0:0.00}", johnnysGrade);
            //studentGrades.Remove("Johnny");

            //Console.WriteLine("Johny's grades have been removed.");

            //Console.WriteLine("Is Johnny's score in the dictionary: {0}", studentGrades.ContainsKey("Johnny") ? "Yes!" : "No!");

            //Console.WriteLine("Billy's score is {0:0.00}.", studentGrades["Billy"]);
            //studentGrades["Billy"] = 3.8;

            //Console.WriteLine("But we all know he deserves no more than {0:0.00}.", studentGrades["Billy"]);

            //double jimmysGrade;
            //bool findJimmy = studentGrades.TryGetValue("Johnny", out jimmysGrade);

            //Console.WriteLine("Is Johnny's grade in the dictionary? {0}", findJimmy ? "Yes!" : "No!");

            //studentGrades["Jimmy"] = 8.00;
            //findJimmy = studentGrades.TryGetValue("Jimmy", out jimmysGrade);

            //Console.WriteLine("Lets try again: {0}. Jimmy's grade is {1}", findJimmy ? "Yes!" : "No!", jimmysGrade);

            //Console.WriteLine("Students and Grades: ");

            //foreach(KeyValuePair<string, double> studentGrade in studentGrades)
            //{
            //    Console.WriteLine("{0} has {1:0.00}", studentGrade.Key, studentGrade.Value);

            //}

            //Console.WriteLine("There are {0} students in the dictionary", studentGrades.Count);
            //studentGrades.Clear();
            //Console.WriteLine("Students dictionary cleared.");
            //Console.WriteLine("Is the dictionary empty: {0}", studentGrades.Count == 0);

            #endregion

            IEqualityComparer<Point3D> comparer = new IEqualityCompExample();
            Dictionary<Point3D, int> dict = new Dictionary<Point3D, int>(comparer);

            dict[new Point3D(4, 2, 5)] = 5;
            dict[new Point3D(1, 2, 3)] = 1;
            dict[new Point3D(3, 1, -1)] = 3;
            dict[new Point3D(1, 2, 3)] = 10;

            foreach (var entry in dict)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }
        }
    }
}