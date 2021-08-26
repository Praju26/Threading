using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    class SuspendResume
    {
        [Obsolete]
        public static void Yeild()
        {
            bool finish = false;
            Thread th = new Thread(() =>
            {
                while (!finish) { }
            });
            Thread th1 = new Thread(() =>
            {
                while (!finish)
                {
                    GC.Collect();
                    Thread.Yield();
                }
            });
            th.Start();
            th1.Start();
            Thread.Sleep(10);
            for (int j = 0; j < 5 * 4 * 2; ++j)
            {
                th.Suspend();
                Thread.Yield();
                th.Resume();
                if ((j + 1) % (5) == 0)
                    Console.Write("Hello ");
                if ((j + 1) % (5 * 4) == 0)
                    Console.WriteLine();
            }
            finish = true;
            th.Join();
            th1.Join();
        }

    }
}
