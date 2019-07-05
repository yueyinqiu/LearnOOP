using System;

namespace Abstract
{
    class Program
    {
        static void Kill(Animal animal)
        {
            animal.Die();
        }
        static void TestAnimal(Animal animal)
        {
            Console.Write("原死亡状态：");
            Console.WriteLine(animal.IsDead);
            Console.Write("发出声音：");
            animal.MakeSound();
            Console.WriteLine("被杀时：");
            Kill(animal);
            Console.Write("新的死亡状态：");
            Console.WriteLine(animal.IsDead);
        }
        static void Main()
        {
            Console.WriteLine("狮子测试：");
            Lion lion = new Lion();
            TestAnimal(lion);

            Console.WriteLine();

            Console.WriteLine("凤凰测试：");
            Animal phoenix = new Phoenix();
            TestAnimal(phoenix);

            // phoenix.IsDead = true;
            Console.ReadKey();
        }
    }
}
