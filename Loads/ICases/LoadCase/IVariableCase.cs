using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IVariableCase : ILoadCase
    {
        Ratio Characteristic { get; } // ψ_0
        Ratio Frequent { get; } // ψ_1
        Ratio QuasiPermanent { get; } // ψ_2
    }
}
