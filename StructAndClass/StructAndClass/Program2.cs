using System;

namespace StructAndClass
{
    class Program2
    {
        static void Main2()
        {
            A a = new A();
            a.Value = 1;
            A a2 = a;
            a2.Value = 2;
            Console.WriteLine(a.Value);

            B b = new B();
            b.Value = 1;
            B b2 = b;
            b2.Value = 2;
            Console.WriteLine(b.Value);

            Console.ReadKey();
        }
    }
}
