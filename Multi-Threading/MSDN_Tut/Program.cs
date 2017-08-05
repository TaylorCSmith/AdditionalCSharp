using System;
using System.Threading;

namespace MSDN_Tut
{
    class Program
    {
        static void Main(string[] args)
        {
            // example 1
            Console.WriteLine("Tread Start/Stop/Join Sample");

            Alpha oAlpha = new Alpha();

            // creating the thread object, passing in the alpha.beta method
            // via a threadstart delegate. this does not start the thread.

            Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));

            // start the thread
            oThread.Start();

            // spin for a while awaiting for the started thread to become alife;
            while (!oThread.IsAlive) ;

            // put the main thread to sleep for 1 millisecond to allow oThread to do some work
            Thread.Sleep(1);

            // request that oThread be stopped
            oThread.Abort(); 

            // wait until oThread finishes. Join also has overloads that will take a millisecond niterval or TimeSpan object.
            oThread.Join();
        }
    }

    // example 1
    public class Alpha
    {
        // this method that will be called wen the thread is started
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
            }
        }
    }
}