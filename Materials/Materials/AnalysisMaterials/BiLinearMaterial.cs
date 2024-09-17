using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials
{
    public class BiLinearMaterial : IBiLinearMaterial
    {
        public Pressure ElasticModulus { get; set; }
        public Pressure YieldStrength { get; set; }
        public Pressure UltimateStrength { get; set; }
        public Strain YieldStrain => new Strain(YieldStrength / ElasticModulus, StrainUnit.Ratio);
        public Strain FailureStrain { get; set; }
        public MaterialType Type { get; set; }

        public BiLinearMaterial(MaterialType type, Pressure elasticModulus, Pressure yieldStrength, Pressure ultimateStrength, Strain failureStrain)
        {
            Type = type;
            ElasticModulus = elasticModulus;
            YieldStrength = yieldStrength;
            UltimateStrength = ultimateStrength;
            FailureStrain = failureStrain;
        }

        public BiLinearMaterial(ILinearElasticMaterial linearElasticMaterial, Pressure ultimateStrength, Strain failureStrain)
        {
            Type = linearElasticMaterial.Type;
            ElasticModulus = linearElasticMaterial.ElasticModulus;
            YieldStrength = linearElasticMaterial.Strength;
            UltimateStrength = ultimateStrength;
            FailureStrain = failureStrain;
        }
    }
}
