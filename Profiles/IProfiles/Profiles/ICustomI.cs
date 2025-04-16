namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ICustomI : IProfile
    {
        Length Height { get; }
        Length TopFlangeWidth { get; }
        Length BottomFlangeWidth { get; }
        Length TopFlangeThickness { get; }
        Length BottomFlangeThickness { get; }
        Length WebThickness { get; }
    }
}
