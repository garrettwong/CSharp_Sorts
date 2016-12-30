using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharp_Sorts
{
    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable<T> GetEnumerableOfType<T>() where T : class
        {
            return from t in Assembly.GetExecutingAssembly().GetTypes()
                   where t.GetInterfaces().Contains(typeof(T))
                           && t.GetConstructor(Type.EmptyTypes) != null
                   select Activator.CreateInstance(t) as T;
        }
    }
}