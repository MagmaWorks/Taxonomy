namespace MagmaWorks.Taxonomy.Profiles
{
    public abstract class SingletonCatalogueBase<T> where T : SingletonCatalogueBase<T>
    {
        private static readonly Lazy<T> _lazy =
            new(() => (Activator.CreateInstance(typeof(T), true) as T)!);

        public static T Default => _lazy.Value;
    }
}
