namespace Static
{
    class TheFields
    {
        public static int numberStatic;
        public int numberNonStatic;
    }
    class TestClass
    {
        public void AMethod()
        {
            // 这里展示了如何使用以上字段。
            int i = 1;

            //静态字段
            TheFields.numberStatic = i;
            i = TheFields.numberStatic;

            //实例字段
            TheFields f = new TheFields();
            f.numberNonStatic = i;
            i = f.numberNonStatic;
        }
    }
}
