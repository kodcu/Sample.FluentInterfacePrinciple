using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0
{
    public static class FluentPersonFactory
    {
        public static IPersonFactory Init()
        {
            return new PersonFactory(new Person());
        }
    }
}
