using MagmaWorks.Taxonomy.Materials;
using OasysUnits;
using OasysUnits.Units;

namespace Materials
{
    public class LinearElasticMaterial : ILinearElasticMaterial
    {
        public Pressure ElasticModulus { get; set; }
        public Pressure Strength { get; set; }
        public MaterialType Type { get; set; }
        public Strain PeakStrain => new Strain(Strength / ElasticModulus, StrainUnit.Ratio);

        public LinearElasticMaterial(MaterialType type, Pressure elasticModulus, Pressure strength)
        {
            Type = type;
            ElasticModulus = elasticModulus;
            Strength = strength;
        }
    }
}
