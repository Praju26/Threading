using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main()
        {
            Multithread multithread = new Multithread();
            multithread.TablesOutput();

            ThreadingMethods ob = new ThreadingMethods();
            Thread th = new Thread(new ThreadStart(ob.Thr));
            th.Start();
            th.Abort();

            ThreadingMethods Ob = new ThreadingMethods();
            Thread Th = new Thread(new ThreadStart(ob.Thr));
            th.Start();
            Console.WriteLine("Aborting the thread");
            th.Abort();

        }
    }
}
