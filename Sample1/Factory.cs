using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public class Factory<T>
        : IFactory<T>
    {
        T instance;

        public Factory(T instance)
        {
            this.instance = instance;
        }

        public T Take()
        {
            return this.instance;
        }

        //public IFactory<T> GiveAValue(string propertyName, object value)
        //{
        //    var pInfo = this.instance.GetType().GetProperty(propertyName);
        //    if (!pInfo.Equals(null))
        //        pInfo.SetValue(instance, value);

        //    return this;

        //}

        public IFactory<T> GiveAValue(Expression<Func<T, object>> property, object value)
        {
            PropertyInfo pInfo = null;

            if (property.Body is MemberExpression)
                pInfo = (property.Body as MemberExpression).Member as PropertyInfo;
            else
                pInfo = (((UnaryExpression)property.Body).Operand as MemberExpression).Member as PropertyInfo;

            pInfo.SetValue(instance, value);

            return this;
        }
    }
}
