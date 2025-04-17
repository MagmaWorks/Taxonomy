namespace MagmaWorks.Taxonomy.Materials
{
    public interface IBiLinearMaterial : IAnalysisMaterial
    {
        Stress ElasticModulus { get; }
        Stress YieldStrength { get; }
        Stress UltimateStrength { get; }
        Strain YieldStrain { get; }
        Strain FailureStrain { get; }
    }
}
