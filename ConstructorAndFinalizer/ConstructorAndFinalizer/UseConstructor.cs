namespace ConstructorAndFinalizer
{
    class Tester
    {
        static void Run()
        {
            UseConstructor aClass = new UseConstructor();

            UseConstructor2 anotherClass = new UseConstructor2(false);
        }
    }
    class UseConstructor
    {
        public bool IsUnconscious { get; set; }
        public UseConstructor()
        {
            IsUnconscious = false;
        }
    }
    class UseConstructor2
    {
        public bool IsUnconscious { get; set; }
        public UseConstructor2(bool isUnconscious)
        {
            IsUnconscious = isUnconscious;
        }
    }
}
