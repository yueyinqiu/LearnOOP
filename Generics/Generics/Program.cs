using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeValues<int> intValues = new ThreeValues<int>();
            intValues.Value1 = 1;
            // intValues.Value2 = 1.333;

            ThreeValues<double> doubleValues = new ThreeValues<double>();
            doubleValues.Value2 = 1.233;

            ThreeValues<ThreeValues<int>> nineValues = new ThreeValues<ThreeValues<int>>();
            nineValues.Value1 = new ThreeValues<int>();
            nineValues.Value1.Value2 = 1;
        }
    }
}
