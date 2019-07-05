namespace CatsAreAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ChangeIntoLiquid();
            cat.Eat();

            Animal animal = new Animal();
            animal.Eat();
            // animal.ChangeIntoLiquid(); 编译不通过。

            Cat cat2 = new Cat();
            Animal aCat = cat2;
            aCat.Eat();
            // aCat.ChangeIntoLiquid(); 编译不通过。
        }
    }
}
