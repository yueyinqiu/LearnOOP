using System;

namespace ConstructorAndFinalizer
{
    class InterestingFinalizer
    {
        // 记录一个 id 以输出。
        string id;

        // 用于占据一定内存空间，使系统较快地执行垃圾回收。
        byte[] bytes = new byte[50000];


        // 一个构造函数。
        public InterestingFinalizer(int id1, int id2)
        {
            id = $"{id1} - {id2}";
        }

        // 一个终结器。
        ~InterestingFinalizer()
        {
            Console.WriteLine($"{id} 被析构了。");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 不断执行，但进行一下计数，便于输出。
            for (int n = 1; ; n++)
            {
                // 等待用户按下回车。
                Console.ReadLine();

                // 创建 20 个 InterestingFinalizer 类的实例。
                for (int i = 1; i <= 20; i++)
                {
                    new InterestingFinalizer(n,i);
                }
                Console.WriteLine($"第{n}批创建完成。");
            }
        }
    }
}
