using System;

namespace CheckThePassword
{
    class Safe // 定义 Safe（保险箱） 类。
    {
        /// <summary>
        /// 尝试打开保险箱。
        /// </summary>
        /// <param name="password">输入的密码。</param>
        /// <returns>打开成功则为 true ；否则为 false 。</returns>
        public bool Open(string password)
        {
            // 这里把正确密码认为是字符串 "CorrectPassword!"
            return (password == "CorrectPassword!"); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Safe mySafe = new Safe(); // 创建一个保险箱。
            string input = Console.ReadLine(); // 读取用户输入的值。

            bool b = mySafe.Open(input); // 尝试打开保险箱。
            if(b) // 判断是否打开成功。
            {
                Console.WriteLine("成功打开！");   
            }
            else
            {
                Console.WriteLine("密码错误！");
            }
            Console.ReadLine();
        }
    }
}
