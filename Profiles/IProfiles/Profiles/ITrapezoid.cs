namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ITrapezoid : IProfile
    {
        Length Height { get; }
        Length TopWidth { get; }
        Length BottomWidth { get; }
    }
}
