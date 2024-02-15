using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IZ : IProfile
    {
        Length Height { get; }
        Length TopFlangeWidth { get; }
        Length BottomFlangeWidth { get; }
        Length Thickness { get; }
        Length TopLip { get; }
        Length BottomLip { get; }
    }
}
