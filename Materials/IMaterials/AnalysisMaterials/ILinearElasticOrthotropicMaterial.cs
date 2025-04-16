namespace MagmaWorks.Taxonomy.Materials
{
    public interface ILinearElasticOrthotropicMaterial : IAnalysisMaterial
    {
        Stress ElasticModulusX { get; }
        Stress ElasticModulusY { get; }
        Stress ElasticModulusZ { get; }
        Stress StrengthX { get; }
        Stress StrengthY { get; }
        Stress StrengthZ { get; }
    }
}
