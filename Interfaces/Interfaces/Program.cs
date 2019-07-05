using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Console.WriteLine(TryOpen(light));
            Console.WriteLine(TryOpen(light));

            Console.WriteLine();
            BrokenLight light2 = new BrokenLight();
            Console.WriteLine(TryOpen(light2));
            Console.WriteLine(TryOpen(light2));

            Console.ReadKey();
        }

        /// <summary>
        /// 尝试打开一个可以被开关的对象。
        /// </summary>
        /// <param name="something">要被打开的对象。</param>
        /// <returns>指示是否打开成功。</returns>
        static bool TryOpen(ISwitchable obj)
        {
            obj.Open();
            return obj.IsOn;
        }
    }
}
