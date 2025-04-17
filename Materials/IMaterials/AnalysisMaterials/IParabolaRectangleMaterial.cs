namespace MagmaWorks.Taxonomy.Materials
{
    public interface IParabolaRectangleMaterial : IAnalysisMaterial
    {
        Stress YieldStrength { get; }
        Strain YieldStrain { get; }
        Strain FailureStrain { get; }
        double Exponent { get; set; }

        public Stress StressAt(Strain strain);
    }
}
