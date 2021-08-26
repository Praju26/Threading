using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    class Multithread
    {
        Thread Thread2, Thread3, Thread4;

        public Multithread()
        {
            Thread2 = new Thread(new ThreadStart(Tables.TableTwo));
            Thread3 = new Thread(new ThreadStart(Tables.TableThree));
            Thread4 = new Thread(new ThreadStart(Tables.TableFour));
        }

        public void TablesOutput()
        {
            Thread2.Start();
            Thread2.Join();
            Thread3.Start();
            Thread3.Join();
            Thread4.Start();
            Thread4.Join();
        }

        public void TablesOutput2()
        {
            Thread4.Start();
            Thread4.Join();
            Thread3.Start();
            Thread3.Join();
            Thread2.Start();
            Thread2.Join();
        }
    }

    class Tables
    {
        internal static ThreadStart TableThree;
        internal static ThreadStart TableFour;

        public static void TableOne(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        public static void TableTwo()
        {
            Console.WriteLine("\nTable of 2");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"2 x {i} = {2 * i}");
            }
        }


    }
}
