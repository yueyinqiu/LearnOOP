namespace Override
{
    class AnotherClass1
    {
        public virtual void Method() { }
    }


    class AnotherClass2 : AnotherClass1
    {
        public sealed override void Method() { }
    }
    class AnotherClass3 : AnotherClass2
    {
        /* 以下代码会产生编译错误：
         * public override void Method() { }
         */
    }
}
