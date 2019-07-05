namespace PropertyExample
{
    public class Person2
    {
        int stature;
        public int Stature
        {
            get
            {
                return stature;
            }
            set
            {
                if (value > 0)
                    stature = value;
            }
        }
    }
}
