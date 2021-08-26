using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    class IntteruptJoin
    {

        class Thread1
        {
            public void Jobthread()
            {
                try
                {
                    for (int r = 0; r < 3; r++)
                    {
                        Console.WriteLine(" Working of thread has begun ");
                        Thread.Sleep(10);
                    }
                }
                catch (ThreadAbortException e)
                {
                    Console.WriteLine("ThreadAbortException is caught and must be reset");
                    Console.WriteLine("The message looks like this: {0}", e.Message);
                    Thread.ResetAbort();
                }
                Console.WriteLine("Thread is working fine");
                Thread.Sleep(200);
                Console.WriteLine("Thread is done");
            }
        }
        class Driver
        {
            public static void AbortJoin()
            {
                Thread1 obj = new Thread1();
                Thread Th = new Thread(obj.Jobthread);
                Th.Start();
                Thread.Sleep(100);
                Console.WriteLine("thread abort");
                Th.Abort();
                Th.Join();
                Console.WriteLine("end of main thread");
            }
        }
    }
}
