using System;

namespace TheDoor
{
    class Door
    {
        public bool isOpen;
        public void Open()
        {
            isOpen = true;
        }
        public void Close()
        {
            isOpen = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 以下注释都在解释上一行的内容。

            Door theFrontDoor = new Door();
            // 定义变量 theFrontDoor（正门） ，创建新的门对其赋值。
            Door theBackDoor = new Door();
            // 定义变量 theBackDoor（后门） ，创建新的门对其赋值。

            theFrontDoor.Close();
            // 关闭正门。
            theBackDoor.Close();
            // 关闭后门。

            theFrontDoor.Open();
            // 打开正门。

            Console.WriteLine(theFrontDoor.isOpen);
            Console.WriteLine(theBackDoor.isOpen);

            Console.ReadLine();
        }
    }
}
