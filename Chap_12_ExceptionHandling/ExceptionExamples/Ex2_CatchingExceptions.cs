using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionExamples
{
    class Ex2_CatchingExceptions
    {

        public static void ReadFile(string fileName)
        {
            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Dispose();
                
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("The file '{0}' is not found.", fileName);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
        }
    }
}
