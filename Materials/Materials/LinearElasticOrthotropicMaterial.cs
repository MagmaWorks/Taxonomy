using MagmaWorks.Taxonomy.Materials;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public class LinearElasticOrthotropicMaterial : ILinearElasticOrthotropicMaterial
    {
        public Pressure ElasticModulusX { get; set; }
        public Pressure ElasticModulusY { get; set; }
        public Pressure ElasticModulusZ { get; set; }
        public Pressure StrengthX { get; set; }
        public Pressure StrengthY { get; set; }
        public Pressure StrengthZ { get; set; }
        public MaterialType Type { get; set; }

        public LinearElasticOrthotropicMaterial(MaterialType type, Pressure elasticModulusX, Pressure strengthX,
            Pressure elasticModulusY, Pressure strengthY, Pressure elasticModulusZ, Pressure strengthZ)
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
