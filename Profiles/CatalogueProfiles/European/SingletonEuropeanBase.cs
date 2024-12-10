using System;

namespace MagmaWorks.Taxonomy.Profiles
{
    public abstract class SingletonEuropeanBase<T> : SingletonCatalogueBase<T>, IEuropeanCatalogue
        where T : SingletonCatalogueBase<T>
    {
        public Enum Type => Shape;
        public Catalogue Catalogue => Catalogue.EuropeanEN10365;
        public abstract EuropeanShape Shape { get; }
        public abstract string Label { get; }
        public virtual string Description => Label;
    }
}
