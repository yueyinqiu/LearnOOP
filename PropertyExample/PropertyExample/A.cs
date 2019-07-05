namespace PropertyExample
{
    class A
    {
        // 只读属性
        public int S
        {
            get
            {
                return 1;
            }
        }

        // 类内可写
        int d;
        public int D
        {
            get
            {
                return d;
            }
            private set
            {
                d = value;
            }
        }

        // 自动属性
        public int F { get; set; }
    }
}
