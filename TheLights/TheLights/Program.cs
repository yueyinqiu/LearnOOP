namespace TheLights
{
    class Program
    {
        static void Main(string[] args) { }
        static bool CheckLight(ILight light)
        {
            if (light.IsOn) { return true; }
            light.Open();
            bool result = light.IsOn;
            light.Close();
            return result;
        }
    }
    interface ILight
    {
        bool IsOn { get; }
        void Open();
        void Close();
    }
}
