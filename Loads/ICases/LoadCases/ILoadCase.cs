using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public interface ILoadCase : ICase
    {
        string Nickname { get; }
        IList<ILoad> Loads { get; }
        bool IsHorizontal { get; }
    }
}
