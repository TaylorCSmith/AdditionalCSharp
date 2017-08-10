using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_TraverseDFS
{
    class Program
    {
        static void Main(string[] args)
        {
            TraverseDir("C:\\Users\\Taylo\\Desktop\\C# Practice");
        }

        private static void TraverseDir(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            DirectoryInfo[] children = dir.GetDirectories();

            // visit subtree of each child
            foreach (DirectoryInfo child in children)
            {
                TraverseDir(child, spaces + " ");
            }
        }

        static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath), string.Empty);
        }
    }
}