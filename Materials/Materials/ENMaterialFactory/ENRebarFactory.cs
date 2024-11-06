using System;
using System.Linq;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.EN
{
    public static class ENRebarFactory
    {
        public static ILinearElasticMaterial CreateLinearElastic(ENRebarGrade grade)
        {
            MaterialType type = MaterialType.Reinforcement;
            double strength = double.Parse(string.Concat(grade.ToString().Where(Char.IsDigit)));
            Pressure f_yk = new Pressure(strength, PressureUnit.Megapascal);
            Pressure elasticModulus = new Pressure(200, PressureUnit.Gigapascal);
            return new LinearElasticMaterial(type, elasticModulus, f_yk);
        }

        public static IBiLinearMaterial CreateBiLinear(ENRebarGrade grade)
        {
            ILinearElasticMaterial material = CreateLinearElastic(grade);
            char rebarClass = grade.ToString()[grade.ToString().Length - 1];
            Strain strain;
            double k;
            switch (rebarClass)
            {
                case 'A':
                    k = 1.05;
                    strain = new Strain(2.5, StrainUnit.Percent);
                    break;

                case 'B':
                    k = 1.08;
                    strain = new Strain(5.0, StrainUnit.Percent);
                    break;

                case 'C':
                    k = 1.15;
                    strain = new Strain(7.5, StrainUnit.Percent);
                    break;

                default:
                    throw new ArgumentException($"Class {rebarClass} not implemented");
            }

            Pressure strength = material.Strength * k;
            return new BiLinearMaterial(material, strength, strain);
        }
    }
}
