namespace Override
{
    class Class1
    {
        public virtual void Method() { }
    }


    class Class2 : Class1
    {
        public override void Method() { }
    }
    class Class3 : Class2
    {
        public override void Method() { }
    }
}
