using System;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials
{
    public static class EurocodeConcreteFactory
    {
        public static ILinearElasticMaterial CreateLinearElasticCompression(EurocodeConcreteGrade grade)
        {
            MaterialType type = MaterialType.Concrete;

            double strength = double.Parse(grade.ToString().Split('C', '_')[1]);
            Pressure f_ck = new Pressure(strength, PressureUnit.Megapascal);

            double strain = 1.75 + 0.55 * ((strength - 50) / 40);
            Strain epsilon_c3 = new Strain(strength <= 50 ? 1.75 : strain, StrainUnit.MilliStrain);

            Pressure elasticModulus = f_ck / epsilon_c3.Ratio;

            return new LinearElasticMaterial(type, elasticModulus, f_ck);
        }

        public static IParabolaRectangleMaterial CreateParabolaRectangleCompression(EurocodeConcreteGrade grade)
        {
            MaterialType type = MaterialType.Concrete;

            double strength = double.Parse(grade.ToString().Split('C', '_')[1]);
            Pressure f_ck = new Pressure(strength, PressureUnit.Megapascal);

            Strain epsilon_c2 = new Strain(strength <= 50
                ? 2.0 : 2 + 0.085 * Math.Pow(strength - 50, 0.53), StrainUnit.MilliStrain);
            Strain epsilon_cu2 = new Strain(strength <= 50
                ? 3.5 : 2.6 + 35 * Math.Pow((90 - strength) / 100, 4), StrainUnit.MilliStrain);
            double exponent = strength <= 50 ? 2.0 : 1.4 + 23.4 * Math.Pow((90 - strength) / 100, 4);

            return new ParabolaRectangleMaterial(type, f_ck, epsilon_c2, epsilon_cu2, exponent);
        }
    }
}
