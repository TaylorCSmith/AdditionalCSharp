using System;
using System.Collections.Generic;

namespace ExceptionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // ****************************** EXAMPLE ONE ************************************

            //Ex1_ThrowingAnException exampleOne = new Ex1_ThrowingAnException(); 
            //string fileName = "WrongTextFile.txt";
            //exampleOne.ReadFile(fileName);

            // ****************************** EXAMPLE TWO ************************************

            string fileName = "WrongTextFile.txt";
            Ex2_CatchingExceptions.ReadFile(fileName); 
        }
    }
}