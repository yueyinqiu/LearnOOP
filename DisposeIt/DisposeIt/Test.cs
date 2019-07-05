using System;

namespace DisposeIt
{
    class Test : IDisposable
    {
        public string S { get; set; }
        public void Dispose()
        {
            Console.WriteLine($"{S} is disposed");
        }
    }
}
