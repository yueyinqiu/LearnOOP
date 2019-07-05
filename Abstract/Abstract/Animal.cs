namespace Abstract
{
    abstract class Animal
    {
        public bool IsDead { get; protected set; }

        public abstract void MakeSound();

        public virtual void Die()
        {
            MakeSound();
            IsDead = true;
        }
    }
}
