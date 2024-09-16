using Materials;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials
{
    public static class EurocodeConcreteFactory
    {
        public static ILinearElasticMaterial CreateCompression(EurocodeConcreteGrade grade)
        {
            MaterialType type = MaterialType.Concrete;

            double strength = double.Parse(grade.ToString().Split('C', '_')[1]);
            Pressure f_ck = new Pressure(strength, PressureUnit.Megapascal);

            double strain = 1.75 + 0.55 * ((strength - 50) / 40);
            Strain epsilon_c3 = new Strain(strength >= 50 ? strain : 1.75, StrainUnit.MilliStrain);

            Pressure elasticModulus = f_ck / epsilon_c3.Ratio;

            return new LinearElasticMaterial(type, elasticModulus, f_ck);
        }
    }
}
