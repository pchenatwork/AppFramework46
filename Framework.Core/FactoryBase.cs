using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Core
{
    /// <summary>
    /// Generic Singlton Factory base to any Factory class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class FactoryBase<T> where T : FactoryBase<T>, new()
    {
        private static readonly Lazy<T> instance = new Lazy<T>(() => new T());
        protected FactoryBase() { }
        public static T Instance  => instance.Value; 
    }
}
