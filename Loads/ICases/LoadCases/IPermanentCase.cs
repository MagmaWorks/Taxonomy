using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPermanentCase : ILoadCase
    {
        /// <summary>
        /// γ_G,j,sup - Unfavourable (superior) partial factor
        /// </summary>
        Ratio Unfavourable { get; }

        /// <summary>
        /// γ_G,j,inf - Favourable (inferior) partial factor
        /// </summary>
        Ratio Favourable { get; }
    }
}
