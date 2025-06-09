namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public interface IVariableCase : ILoadCase
    {
        /// <summary>
        /// ψ_0 Factor for combination value of a variable action
        /// </summary>
        Ratio CombinationFactor { get; }

        /// <summary>
        /// ψ_1 Factor for frequent value of a variable action
        /// </summary>
        Ratio FrequentFactor { get; }

        /// <summary>
        /// ψ_2 Factor for quasi-permanent value of a variable action
        /// </summary>
        Ratio QuasiPermanentFactor { get; }
    }
}
