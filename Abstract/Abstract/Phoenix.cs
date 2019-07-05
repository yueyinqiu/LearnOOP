using System;

namespace Abstract
{
    class Phoenix : Animal 
    {
        public override void MakeSound()
        {
            Console.WriteLine("Clang");
        }

        private void BeResurrected()
        {
            IsDead = false;
            Console.WriteLine("我复活了！");
            MakeSound();
            MakeSound();
        }

        public override void Die()
        {
            base.Die();
            BeResurrected();
        }
    }
}
