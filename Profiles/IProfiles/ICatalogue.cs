namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ICatalogue : IProfile
    {
        Catalogue Catalogue { get; }
        Enum Type { get; }
        string Label { get; }
    }
}
