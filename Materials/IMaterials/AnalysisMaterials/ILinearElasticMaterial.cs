using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface ILinearElasticMaterial : IAnalysisMaterial
    {
        Pressure ElasticModulus { get; }
        Pressure Strength { get; }
        Strain PeakStrain { get; }
    }
}
