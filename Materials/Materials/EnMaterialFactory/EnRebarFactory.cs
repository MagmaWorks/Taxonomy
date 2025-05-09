﻿using System.Linq;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public static class EnRebarFactory
    {
        public static ILinearElasticMaterial CreateLinearElastic<T>(T grade) where T : Enum
        {
            MaterialType type = MaterialType.Reinforcement;
            double strength = double.Parse(string.Concat(grade.ToString().Where(Char.IsDigit)));
            Stress f_yk = new Stress(strength, StressUnit.Megapascal);
            Stress elasticModulus = new Stress(200, StressUnit.Gigapascal);
            return new LinearElasticMaterial(type, elasticModulus, f_yk);
        }

        public static IBiLinearMaterial CreateBiLinear(EnRebarGrade grade)
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

            Stress strength = material.Strength * k;
            return new BiLinearMaterial(material, strength, strain);
        }
    }
}
