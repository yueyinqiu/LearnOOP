using System;

namespace PersonAndDoor
{
    class Door
    {
        public bool isOpen;
        public string name;
        public void Open()
        {
            isOpen = true;
            Console.WriteLine(name + "被打开了。");
        }
        public void Close()
        {
            isOpen = false;
            Console.WriteLine(name + "被关闭了。");
        }
    }
}
