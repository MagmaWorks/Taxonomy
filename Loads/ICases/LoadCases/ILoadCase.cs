using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoadCase : ICase
    {
        string Nickname { get; }
        IList<ILoad> Loads { get; }
        bool IsFavourable { get; }
        bool IsHorizontal { get; }
    }
}
