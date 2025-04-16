namespace MagmaWorks.Taxonomy.Materials
{
    public class BiLinearMaterial : IBiLinearMaterial
    {
        public Stress ElasticModulus { get; set; }
        public Stress YieldStrength { get; set; }
        public Stress UltimateStrength { get; set; }
        public Strain YieldStrain => new Strain(YieldStrength / ElasticModulus, StrainUnit.DecimalFraction);
        public Strain FailureStrain { get; set; }
        public MaterialType Type { get; set; }

        private BiLinearMaterial() { }

        public BiLinearMaterial(MaterialType type, Stress elasticModulus, Stress yieldStrength, Stress ultimateStrength, Strain failureStrain)
        {
            Type = type;
            ElasticModulus = elasticModulus;
            YieldStrength = yieldStrength;
            UltimateStrength = ultimateStrength;
            FailureStrain = failureStrain;
        }

        public BiLinearMaterial(ILinearElasticMaterial linearElasticMaterial, Stress ultimateStrength, Strain failureStrain)
        {
            Type = linearElasticMaterial.Type;
            ElasticModulus = linearElasticMaterial.ElasticModulus;
            YieldStrength = linearElasticMaterial.Strength;
            UltimateStrength = ultimateStrength;
            FailureStrain = failureStrain;
        }
    }
}
