using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPermanentCase : ILoadCase
    {
        Ratio Unfavourable { get; }
        Ratio Favourable { get; }
    }
}
