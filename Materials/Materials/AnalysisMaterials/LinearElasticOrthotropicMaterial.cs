namespace MagmaWorks.Taxonomy.Materials
{
    public class LinearElasticOrthotropicMaterial : ILinearElasticOrthotropicMaterial
    {
        public Stress ElasticModulusX { get; set; }
        public Stress ElasticModulusY { get; set; }
        public Stress ElasticModulusZ { get; set; }
        public Stress StrengthX { get; set; }
        public Stress StrengthY { get; set; }
        public Stress StrengthZ { get; set; }
        public MaterialType Type { get; set; }

        public LinearElasticOrthotropicMaterial(MaterialType type, Stress elasticModulusX, Stress strengthX,
            Stress elasticModulusY, Stress strengthY, Stress elasticModulusZ, Stress strengthZ)
        {
            Type = type;
            ElasticModulusX = elasticModulusX;
            StrengthX = strengthX;
            ElasticModulusY = elasticModulusY;
            StrengthY = strengthY;
            ElasticModulusZ = elasticModulusZ;
            StrengthZ = strengthZ;
        }
    }
}
