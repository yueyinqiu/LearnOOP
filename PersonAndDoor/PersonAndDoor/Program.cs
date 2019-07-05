using System;

namespace PersonAndDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Door doorOfLight = new Door();
            doorOfLight.name = "光明之门";
            doorOfLight.isOpen = false;

            Door doorOfDarkness = new Door();
            doorOfDarkness.name = "黑暗之门";
            doorOfLight.isOpen = false;

            Door aNormalDoor = new Door();
            aNormalDoor.name = "小明家的门";
            doorOfLight.isOpen = false;



            Person smallBright = new Person();
            smallBright.name = "小明";

            Person sorcerer = new Person();
            sorcerer.name = "巫师";

            Person pastor = new Person();
            pastor.name = "新教牧师";



            Console.WriteLine("故事开始了：");
            Console.WriteLine();
            Console.WriteLine("Part 1：");
            doorOfLight.Open();
            sorcerer.GoThrough(doorOfLight);
            pastor.GoThrough(doorOfLight);
            doorOfLight.Close();

            Console.WriteLine();
            Console.WriteLine("Part 2：");
            smallBright.GoThrough(aNormalDoor);

            Console.WriteLine();
            Console.WriteLine("Part 3：");
            doorOfDarkness.Open();
            sorcerer.GoThrough(doorOfDarkness);
            doorOfDarkness.Close();
            pastor.GoThrough(doorOfDarkness);

            Console.WriteLine();
            Console.WriteLine("Part 4：");
            aNormalDoor.Open();
            sorcerer.GoThrough(aNormalDoor);
            aNormalDoor.Close();

            Console.WriteLine();
            Console.WriteLine("Part 5：");
            pastor.GoThrough(doorOfLight);

            Console.ReadLine();
        }
    }
}
