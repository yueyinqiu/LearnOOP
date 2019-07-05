using System;

namespace Interfaces
{
    class BrokenLight : ISwitchable
    {
        public bool IsOn { get; private set; } = false;

        public void Close()
        {
            // 什么都不做。
        }

        public void Open()
        {
            Console.WriteLine("这灯打不开。");
        }
    }
}
