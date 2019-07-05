using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsAndAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Kill(new Cat());
            Kill(new Bird());
            Kill(new Animal());
        }

        static void Kill(Animal animal)
        {
            animal.Die();
        }
    }
}
