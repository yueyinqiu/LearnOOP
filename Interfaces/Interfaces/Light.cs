using System;

namespace Interfaces
{
    class Light : ISwitchable
    {
        public bool IsOn { get; private set; } = false;

        public void Close()
        {
            if(IsOn)
            {
                Console.WriteLine("房间变暗了。");
                IsOn = false;
            }
        }

        public void Open()
        {
            if (!IsOn)
            {
                Console.WriteLine("房间被照亮了。");
                IsOn = true;
            }
        }
    }
}
