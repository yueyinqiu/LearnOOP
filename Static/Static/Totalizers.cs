namespace Static
{
    class Totalizer1
    {
        public int Value { get; private set; }

        public void Add(int valueToAdd)
        {
            Value += valueToAdd;
        }
    }

    class Totalizer2
    {
        public int Value { get; private set; }

        public static void Add(Totalizer2 totalizer, int valueToAdd)
        {
            totalizer.Value += valueToAdd;
        }
    }
}
