using System;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ICatalogue : IProfile
    {
        Catalogue Catalogue { get; }
        Enum Type { get; }
        string Designation { get; }
    }
}
