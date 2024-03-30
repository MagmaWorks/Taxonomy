using System;

namespace MagmaWorks.Taxonomy.Profiles
{
    public abstract class SingletonAmericanBase<T> : SingletonCatalogueBase<T>, IAmericanCatalogue
        where T : SingletonCatalogueBase<T>
    {
        public Enum Type => Shape;
        public Catalogue Catalogue => Catalogue.AmericanAISC;
        public abstract AmericanShape Shape { get; }
        public abstract string Label { get; }
    }
}
