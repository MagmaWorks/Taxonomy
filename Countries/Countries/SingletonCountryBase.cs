using System;

namespace MagmaWorks.Taxonomy.Countries
{
    public abstract class SingletonCountryBase<T> where T : SingletonCountryBase<T>
    {
        private static readonly Lazy<T> _lazy =
            new(() => (Activator.CreateInstance(typeof(T), true) as T)!);

        public static T Default => _lazy.Value;
    }
}
