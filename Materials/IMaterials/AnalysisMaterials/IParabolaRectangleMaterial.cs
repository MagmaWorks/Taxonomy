using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IParabolaRectangleMaterial : IAnalysisMaterial
    {
        Pressure YieldStrength { get; }
        Strain YieldStrain { get; }
        Strain FailureStrain { get; }
        double Exponent { get; set; }

        public Pressure StressAt(Strain strain);
    }
}
