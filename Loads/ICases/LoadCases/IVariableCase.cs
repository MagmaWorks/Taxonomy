namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public interface IVariableCase : ILoadCase
    {
        /// <summary>
        /// ψ_0 Characteristic partial factor
        /// </summary>
        Ratio Characteristic { get; }

        /// <summary>
        /// ψ_1 Frequent partial factor
        /// </summary>
        Ratio Frequent { get; }

        /// <summary>
        /// ψ_2 Quasi-permanent partial factor
        /// </summary>
        Ratio QuasiPermanent { get; }
    }
}
