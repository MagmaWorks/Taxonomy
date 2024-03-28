using System;

namespace MagmaWorks.Taxonomy.Profiles
{
    public abstract class SingletonEuropeanBase<T> : SingletonCatalogueBase<T>, IEuropeanCatalogue
        where T : SingletonCatalogueBase<T>
    {
        public Enum Type => ShapeType;
        public Catalogue Catalogue => Catalogue.EuropeanEN10365;
        public abstract EuropeanShapeType ShapeType { get; }
        public abstract string Designation { get; }
    }
}
