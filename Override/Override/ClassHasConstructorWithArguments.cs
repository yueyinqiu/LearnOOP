namespace Override
{
    class ClassHasConstructorWithArguments
    {
        public ClassHasConstructorWithArguments(string argument) { }
    }

    class ChildClass : ClassHasConstructorWithArguments
    {
        public ChildClass(string argument) : base(argument) { }

        public ChildClass() : base("arg") { }

        public ChildClass(int i) : this(i.ToString()) { }
    }
}
