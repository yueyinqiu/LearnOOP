using System;
using System.Diagnostics;

namespace Eating
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 0; i < 10000; i++)
            {
                Way1();
            }
            stopwatch1.Stop();


            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                Way2();
            }
            stopwatch2.Stop();

            Console.WriteLine(stopwatch1.ElapsedTicks);
            Console.WriteLine(stopwatch2.ElapsedTicks);

            Console.ReadLine();
        }
        static void Way1()
        {
            new Person1().Eat(new Cookie("cookie"));
        }
        static void Way2()
        {
            new Person2().Eat<Cookie>(new Cookie("cookie"));
        }
    }
}
