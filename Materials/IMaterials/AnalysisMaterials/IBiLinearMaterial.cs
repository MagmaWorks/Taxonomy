using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IBiLinearMaterial : IAnalysisMaterial
    {
        Pressure ElasticModulus { get; }
        Pressure YieldStrength { get; }
        Pressure UltimateStrength { get; }
        Strain YieldStrain { get; }
        Strain FailureStrain { get; }
    }
}
