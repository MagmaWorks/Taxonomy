﻿using System;
using System.Collections.Generic;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public static class EnSteelFactory
    {
        public static ILinearElasticMaterial CreateLinearElastic<T>(T grade) where T : Enum
        {
            MaterialType type = MaterialType.Steel;
            Pressure elasticModulus = new Pressure(210, PressureUnit.Gigapascal);
            Pressure yieldStrength = EN1993_1_1_Table3_1[grade].F_y_40mmOrLess;
            return new LinearElasticMaterial(type, elasticModulus, yieldStrength);
        }

        public static ILinearElasticMaterial CreateLinearElastic(EnSteelGrade grade, Length elementThickness)
        {
            MaterialType type = MaterialType.Steel;
            Pressure elasticModulus = new Pressure(210, PressureUnit.Gigapascal);
            Pressure yieldStrength;
            if (elementThickness.Millimeters > 80)
            {
                throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 80mm");
            }
            else if (elementThickness.Millimeters <= 40)
            {
                yieldStrength = EN1993_1_1_Table3_1[grade].F_y_40mmOrLess;
                if (yieldStrength.Value == 0)
                {
                    throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 40mm for Grade {grade}");
                }
            }
            else
            {
                yieldStrength = EN1993_1_1_Table3_1[grade].F_y_40To80mm;
            }

            return new LinearElasticMaterial(type, elasticModulus, yieldStrength);
        }

        public static IBiLinearMaterial CreateBiLinear(EnSteelGrade grade)
        {
            ILinearElasticMaterial material = CreateLinearElastic(grade);
            Pressure ultimateStrength = EN1993_1_1_Table3_1[grade].F_u_40mmOrLess;
            Strain failureStrain = new Strain(15 * material.Strength / material.ElasticModulus, StrainUnit.Ratio);
            return new BiLinearMaterial(material, ultimateStrength, failureStrain);
        }

        public static IBiLinearMaterial CreateBiLinear(EnSteelGrade grade, Length elementThickness)
        {
            ILinearElasticMaterial material = CreateLinearElastic(grade, elementThickness);
            Pressure ultimateStrength;
            if (elementThickness.Millimeters > 80)
            {
                throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 80mm");
            }
            else if (elementThickness.Millimeters <= 40)
            {
                ultimateStrength = EN1993_1_1_Table3_1[grade].F_u_40mmOrLess;
            }
            else
            {
                ultimateStrength = EN1993_1_1_Table3_1[grade].F_u_40To80mm;
                if (ultimateStrength.Value == 0)
                {
                    throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 40mm for grade {grade}");
                }
            }

            Strain failureStrain = new Strain(15 * material.Strength / material.ElasticModulus, StrainUnit.Ratio);
            return new BiLinearMaterial(material, ultimateStrength, failureStrain);
        }

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1 = new()
        {
            { EnSteelGrade.S235, new Table3_1Properties(235, 360, 215, 360) },
            { EnSteelGrade.S275, new Table3_1Properties(275, 430, 255, 410) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 490, 335, 470) },
            { EnSteelGrade.S450, new Table3_1Properties(440, 550, 410, 550) },

            { EnSteelGrade.S275N, new Table3_1Properties(275, 390, 255, 370) },
            { EnSteelGrade.S355N, new Table3_1Properties(355, 490, 335, 470) },
            { EnSteelGrade.S420N, new Table3_1Properties(420, 520, 390, 520) },
            { EnSteelGrade.S460N, new Table3_1Properties(460, 540, 430, 540) },

            { EnSteelGrade.S275M, new Table3_1Properties(275, 370, 255, 360) },
            { EnSteelGrade.S355M, new Table3_1Properties(355, 470, 335, 450) },
            { EnSteelGrade.S420M, new Table3_1Properties(420, 520, 390, 500) },
            { EnSteelGrade.S460M, new Table3_1Properties(460, 540, 430, 530) },

            { EnSteelGrade.S235W, new Table3_1Properties(235, 360, 215, 340) },
            { EnSteelGrade.S355W, new Table3_1Properties(355, 490, 335, 490) },

            { EnSteelGrade.S460Q, new Table3_1Properties(460, 570, 440, 550) },

            { EnSteelGrade.S235H, new Table3_1Properties(235, 360, 215, 340) },
            { EnSteelGrade.S275H, new Table3_1Properties(275, 430, 255, 410) },
            { EnSteelGrade.S355H, new Table3_1Properties(355, 510, 335, 490) },

            { EnSteelGrade.S275NH, new Table3_1Properties(275, 390, 255, 370) },
            { EnSteelGrade.S355NH, new Table3_1Properties(355, 490, 335, 470) },
            { EnSteelGrade.S420NH, new Table3_1Properties(420, 540, 390, 520) },
            { EnSteelGrade.S460NH, new Table3_1Properties(460, 560, 430, 550) },

            { EnSteelGrade.S275MH, new Table3_1Properties(275, 360, 0, 0) },
            { EnSteelGrade.S355MH, new Table3_1Properties(355, 470, 0, 0) },
            { EnSteelGrade.S420MH, new Table3_1Properties(420, 500, 0, 0) },
            { EnSteelGrade.S460MH, new Table3_1Properties(460, 530, 0, 0) },
        };

        private struct Table3_1Properties
        {
            internal Pressure F_y_40mmOrLess;
            internal Pressure F_u_40mmOrLess;
            internal Pressure F_y_40To80mm;
            internal Pressure F_u_40To80mm;

            internal Table3_1Properties(double f_y_40mmOrLess, double f_u_40mmOrLess, double f_y_40To80mm, double f_u_40To80mm)
            {
                PressureUnit unit = PressureUnit.Megapascal;
                F_y_40mmOrLess = new Pressure(f_y_40mmOrLess, unit);
                F_u_40mmOrLess = new Pressure(f_u_40mmOrLess, unit);
                F_y_40To80mm = new Pressure(f_y_40To80mm, unit);
                F_u_40To80mm = new Pressure(f_u_40To80mm, unit);
            }
        }
    }
}