namespace PropertyExample
{
    class Person1
    {
        int stature;
        public int GetStature()
        {
            return stature;
        }
        public void SetStature(int value)
        {
            if (value > 0)
                stature = value;
        }
    }
}
