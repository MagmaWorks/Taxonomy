namespace MagmaWorks.Taxonomy.Materials
{
    public class ParabolaRectangleMaterial : IParabolaRectangleMaterial
    {
        public MaterialType Type { get; set; }
        public Stress YieldStrength { get; set; }
        public Strain YieldStrain { get; set; }
        public Strain FailureStrain { get; set; }
        public double Exponent { get; set; }

        public ParabolaRectangleMaterial(MaterialType type, Stress yieldStrength, Strain yieldStrain, Strain failureStrain, double exponent)
        {
            Type = type;
            YieldStrength = yieldStrength;
            YieldStrain = yieldStrain;
            FailureStrain = failureStrain;
            Exponent = exponent;
        }

        public Stress StressAt(Strain strain)
        {
            if (strain > FailureStrain)
            {
                throw new ArgumentException($"Input {strain} is larger than Failure Strain ({FailureStrain})");
            }

            if (strain >= YieldStrain)
            {
                return YieldStrength;
            }

            return YieldStrength * (1 - Math.Pow(1 - strain / YieldStrain, Exponent));
        }
    }
}
