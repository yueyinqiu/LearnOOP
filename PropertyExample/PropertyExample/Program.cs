using System;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 person1 = new Person1();
            person1.SetStature(170);
            Console.WriteLine(person1.GetStature());

            Person2 person2 = new Person2();
            person2.Stature = 170;
            Console.WriteLine(person2.Stature);
        }
    }
}
