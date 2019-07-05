using System;

namespace PersonAndDoor
{
    class Person
    {
        public bool isUnconscious = false;
        public string name;
        public void GoThrough(Door door)
        {
            if(isUnconscious)
            {
                Console.WriteLine(name + "已经晕过去了。");
                return;
            }
            if (!door.isOpen)
            {
                Console.WriteLine(name + "一头撞在" + door.name + "上不省人事。");
                isUnconscious = true;
            }
            else
            {
                Console.WriteLine(name + "穿过了" + door.name + "。");
            }
        }
    }
}
