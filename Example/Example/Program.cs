namespace Example
{
    class Door
    {
        public void Open()
        {
            // 做一些事
        }
        public void Close()
        {
            // 做一些事
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Door myDoor = new Door(); // 创建一个新的门，并用变量"myDoor"引用它。

            myDoor.Open();// 打开这扇门。
            myDoor.Close();// 关闭这扇门。
        }
    }
}
