using System;

namespace Static
{
    class Program
    {
        static void Main()
        {
            // Person person = new Person();
            // Person person = new Person(false);

            Console.WriteLine(Person.TotalPopulation);

            Person adam = Person.Adam;
            Console.WriteLine(Person.TotalPopulation);

            Person childOfAdamAndEve = adam.MakeABabyWith(Person.Eve);
            Console.WriteLine(Person.TotalPopulation);

            Person child2;
            Console.WriteLine(Person.TotalPopulation);

            if (childOfAdamAndEve.IsMale)
            {
                child2 = Person.Eve.MakeABabyWith(childOfAdamAndEve);
            }
            else
            {
                child2 = childOfAdamAndEve.MakeABabyWith(adam);
            }
            Console.WriteLine(Person.TotalPopulation);

            Person.Adam.Die();
            Console.WriteLine(Person.TotalPopulation);
            Console.WriteLine(adam.IsDead);

            Console.ReadKey();
        }
    }
}
