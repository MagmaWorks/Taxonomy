using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoadCase : ICase
    {
        IList<ILoad> Loads { get; }
    }
}
