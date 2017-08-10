// the majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. Write a program that finds the majorant
// of a given array and prints it. If it does not exist, print "... is not a majorant!"

using System;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MajorantFinder.FindMajorant();
            MajorantFinder.FilterList();
        }
    }
}