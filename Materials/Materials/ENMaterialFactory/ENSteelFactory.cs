using System;
using System.Collections.Generic;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials
{
    public static class ENSteelFactory
    {
        public static IStandardMaterial CreateStandardMaterial(ENSteelGrade grade, NationalAnnex nationalAnnex)
        {
            IEurocode standard = new EN1993(EN1993Part.Part1_1, nationalAnnex);
            return new StandardMaterial(MaterialType.Steel, standard, grade);
        }

        public static ILinearElasticMaterial CreateLinearElastic(ENSteelGrade grade)
        {
            MaterialType type = MaterialType.Steel;
            Pressure elasticModulus = new Pressure(210, PressureUnit.Gigapascal);
            Pressure yieldStrength = EN1993_1_1_Table3_1[grade].F_y_40mmOrLess;
            return new LinearElasticMaterial(type, elasticModulus, yieldStrength);
        }

        public static ILinearElasticMaterial CreateLinearElastic(ENSteelGrade grade, Length elementThickness)
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

        public static IBiLinearMaterial CreateBiLinear(ENSteelGrade grade)
        {
            ILinearElasticMaterial material = CreateLinearElastic(grade);
            Pressure ultimateStrength = EN1993_1_1_Table3_1[grade].F_u_40mmOrLess;
            Strain failureStrain = new Strain(15 * material.Strength / material.ElasticModulus, StrainUnit.Ratio);
            return new BiLinearMaterial(material, ultimateStrength, failureStrain);
        }

        public static IBiLinearMaterial CreateBiLinear(ENSteelGrade grade, Length elementThickness)
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

        private static readonly Dictionary<ENSteelGrade, Table3_1Properties> EN1993_1_1_Table3_1 = new()
        {
            { ENSteelGrade.S235, new Table3_1Properties(235, 360, 215, 360) },
            { ENSteelGrade.S275, new Table3_1Properties(275, 430, 255, 410) },
            { ENSteelGrade.S355, new Table3_1Properties(355, 490, 335, 470) },
            { ENSteelGrade.S450, new Table3_1Properties(440, 550, 410, 550) },

            { ENSteelGrade.S275N, new Table3_1Properties(275, 390, 255, 370) },
            { ENSteelGrade.S355N, new Table3_1Properties(355, 490, 335, 470) },
            { ENSteelGrade.S420N, new Table3_1Properties(420, 520, 390, 520) },
            { ENSteelGrade.S460N, new Table3_1Properties(460, 540, 430, 540) },

            { ENSteelGrade.S275M, new Table3_1Properties(275, 370, 255, 360) },
            { ENSteelGrade.S355M, new Table3_1Properties(355, 470, 335, 450) },
            { ENSteelGrade.S420M, new Table3_1Properties(420, 520, 390, 500) },
            { ENSteelGrade.S460M, new Table3_1Properties(460, 540, 430, 530) },

            { ENSteelGrade.S235W, new Table3_1Properties(235, 360, 215, 340) },
            { ENSteelGrade.S355W, new Table3_1Properties(355, 490, 335, 490) },

            { ENSteelGrade.S460Q, new Table3_1Properties(460, 570, 440, 550) },

            { ENSteelGrade.S235H, new Table3_1Properties(235, 360, 215, 340) },
            { ENSteelGrade.S275H, new Table3_1Properties(275, 430, 255, 410) },
            { ENSteelGrade.S355H, new Table3_1Properties(355, 510, 335, 490) },

            { ENSteelGrade.S275NH, new Table3_1Properties(275, 390, 255, 370) },
            { ENSteelGrade.S355NH, new Table3_1Properties(355, 490, 335, 470) },
            { ENSteelGrade.S420NH, new Table3_1Properties(420, 540, 390, 520) },
            { ENSteelGrade.S460NH, new Table3_1Properties(460, 560, 430, 550) },

            { ENSteelGrade.S275MH, new Table3_1Properties(275, 360, 0, 0) },
            { ENSteelGrade.S355MH, new Table3_1Properties(355, 470, 0, 0) },
            { ENSteelGrade.S420MH, new Table3_1Properties(420, 500, 0, 0) },
            { ENSteelGrade.S460MH, new Table3_1Properties(460, 530, 0, 0) },
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
