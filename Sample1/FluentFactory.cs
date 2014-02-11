using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public static class FluentFactory<T>
        where T : class,new()
    {
        public static IFactory<T> Initialize(T instance)
        {
            return new Factory<T>(instance);
        }
    }
}
