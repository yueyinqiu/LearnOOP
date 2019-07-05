using System;

namespace DisposeIt
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Test t = new Test())
            {
                t.S = "ohh";
            }
            Console.ReadKey();
        }
    }
}
