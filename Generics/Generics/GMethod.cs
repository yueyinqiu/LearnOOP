using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GMethod
    {
        public TResult Convert<T,TResult>(T obj)
        {
            return (TResult)System.Convert.ChangeType(obj, typeof(TResult));
        }
    }
}
