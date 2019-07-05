using System;

namespace StructAndClass
{
    struct A
    {
        public int Value { get; set; }
    }
    class B
    {
        public int Value { get; set; }
    }
    class Program
    {
        static void Main()
        {
            A a = new A();
            a.Value = 1;
            ChangeValue(a);
            Console.WriteLine(a.Value);

            B b = new B();
            b.Value = 1;
            ChangeValue(b);
            Console.WriteLine(b.Value);

            Console.ReadKey();
        }

        static void ChangeValue(A a)
        {
            a.Value = 2;
        }
        static void ChangeValue(B b)
        {
            b.Value = 2;
        }
    }
}
