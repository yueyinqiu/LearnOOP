using System;

namespace CatsAreAnimals
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("这个动物吃了点东西！");
        }
    }
    class Cat : Animal
    {
        public void ChangeIntoLiquid()
        {
            Console.WriteLine("这只猫变成了液体！");
        }
    }
}
