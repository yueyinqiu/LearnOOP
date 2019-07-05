using System;

namespace Override
{
    class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("鸟飞起来了！");
        }
    }
    class Ostrich : Bird
    {
        public override void Fly()
        {
            base.Fly();
            Console.WriteLine("然后掉了下来。");
        }
    }
}
