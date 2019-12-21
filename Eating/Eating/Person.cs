using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eating
{
    class Person1
    {
        public void Eat(IFood food)
        {
            Console.WriteLine($"{food.Name}被吃了");
        }
    }
    class Person2
    {
        public void Eat<T>(T food) where T : IFood
        {
            Console.WriteLine($"{food.Name}被吃了");
        }
    }
}