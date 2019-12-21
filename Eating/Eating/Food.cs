using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eating
{
    interface IFood
    {
        string Name { get; }
    }
    class Cookie : IFood
    { 
        public string Name { get; }
        public Cookie(string name)
        {
            Name = name;
        }
    }
}
