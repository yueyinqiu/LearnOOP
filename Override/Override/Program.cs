using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Fly();

            Console.WriteLine();
            Ostrich ostrich = new Ostrich();
            ostrich.Fly();

            Console.WriteLine();
            Bird bird2 = new Ostrich();
            bird2.Fly();

            Console.ReadKey();
        }
    }
}
