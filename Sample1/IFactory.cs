using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public interface IFactory<T>
    {
        T Take();
        //IFactory<T> GiveAValue(string propertyName, object Value);
        IFactory<T> GiveAValue(Expression<Func<T, object>> property, object value);
    }
}
