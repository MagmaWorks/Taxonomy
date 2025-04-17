namespace MagmaWorks.Taxonomy.Materials
{
    public class LinearElasticMaterial : ILinearElasticMaterial
    {
        public Stress ElasticModulus { get; set; }
        public Stress Strength { get; set; }
        public MaterialType Type { get; set; }
        public Strain PeakStrain => new Strain(Strength / ElasticModulus, StrainUnit.DecimalFraction);

        public LinearElasticMaterial(MaterialType type, Stress elasticModulus, Stress strength)
        {
            Type = type;
            ElasticModulus = elasticModulus;
            Strength = strength;
        }
    }
}
