using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IC : IChannelParallelFlange
    {
        Length Lip { get; }
    }
}
