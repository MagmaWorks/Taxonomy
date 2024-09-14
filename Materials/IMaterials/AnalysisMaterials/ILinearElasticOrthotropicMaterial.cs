using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface ILinearElasticOrthotropicMaterial : IAnalysisMaterial
    {
        Pressure ElasticModulusX { get; }
        Pressure ElasticModulusY { get; }
        Pressure ElasticModulusZ { get; }
        Pressure StrengthX { get; }
        Pressure StrengthY { get; }
        Pressure StrengthZ { get; }
    }
}
