using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoad
    {
        string Label { get; }
        ILoad Factor(Ratio factor);
    }
}
