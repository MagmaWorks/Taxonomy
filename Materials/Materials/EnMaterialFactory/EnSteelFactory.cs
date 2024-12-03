using System;
using System.Collections.Generic;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public static class EnSteelFactory
    {
        public static ILinearElasticMaterial CreateLinearElastic(IEnSteelMaterial material)
        {
            return CreateLinearElastic(material, new Length(40, LengthUnit.Millimeter));
        }

        public static ILinearElasticMaterial CreateLinearElastic(IEnSteelMaterial material, Length elementThickness)
        {
            MaterialType type = MaterialType.Steel;
            Pressure elasticModulus = new Pressure(210, PressureUnit.Gigapascal);
            Pressure yieldStrength;
            Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1 = GetTable3_1Properties(material.Specification);
            if (elementThickness.Millimeters > 80)
            {
                throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 80mm");
            }
            else if (elementThickness.Millimeters <= 40)
            {
                if (EN1993_1_1_Table3_1.ContainsKey(material.Grade))
                {
                    yieldStrength = EN1993_1_1_Table3_1[material.Grade].F_y_40mmOrLess;
                }
                else
                {
                    throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 40mm for Grade {material.Grade}");
                }
            }
            else
            {
                yieldStrength = EN1993_1_1_Table3_1[material.Grade].F_y_40To80mm;
            }

            return new LinearElasticMaterial(type, elasticModulus, yieldStrength);
        }

        public static IBiLinearMaterial CreateBiLinear(IEnSteelMaterial material)
        {
            ILinearElasticMaterial analysisMaterial = CreateLinearElastic(material, new Length(40, LengthUnit.Millimeter));
            Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1 = GetTable3_1Properties(material.Specification);
            Pressure ultimateStrength = EN1993_1_1_Table3_1[material.Grade].F_u_40mmOrLess;
            Strain failureStrain = new Strain(15 * analysisMaterial.Strength / analysisMaterial.ElasticModulus, StrainUnit.Ratio);
            return new BiLinearMaterial(analysisMaterial, ultimateStrength, failureStrain);
        }

        public static IBiLinearMaterial CreateBiLinear(IEnSteelMaterial material, Length elementThickness)
        {
            ILinearElasticMaterial analysisMaterial = CreateLinearElastic(material, elementThickness);
            Pressure ultimateStrength;
            Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1 = GetTable3_1Properties(material.Specification);
            if (elementThickness.Millimeters > 80)
            {
                throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 80mm");
            }
            else if (elementThickness.Millimeters <= 40)
            {
                ultimateStrength = EN1993_1_1_Table3_1[material.Grade].F_u_40mmOrLess;
            }
            else
            {
                ultimateStrength = EN1993_1_1_Table3_1[material.Grade].F_u_40To80mm;
                if (ultimateStrength.Value == 0)
                {
                    throw new ArgumentException($"Nominal thickness of the element ({elementThickness}) must be less or equal to 40mm for grade {material.Grade}");
                }
            }

            Strain failureStrain = new Strain(15 * analysisMaterial.Strength / analysisMaterial.ElasticModulus, StrainUnit.Ratio);
            return new BiLinearMaterial(analysisMaterial, ultimateStrength, failureStrain);
        }

        private static Dictionary<Enum, Table3_1Properties> GetTable3_1Properties(IEnSteelSpecification specification)
        {
            if (specification.FormingTemperature == EnSteelFormingTemperature.ColdFormed)
            {
                throw new ArgumentException("Unable to get EN1993-1-1, Table 3.1 values for Cold Formed steel. ");
            }

            switch (specification.DeliveryCondition)
            {
                case EnSteelDeliveryCondition.AR:
                    return specification.HollowSection ? EN1993_1_1_Table3_1_ARH : EN1993_1_1_Table3_1_AR;

                case EnSteelDeliveryCondition.N:
                    return specification.HollowSection ? EN1993_1_1_Table3_1_NH : EN1993_1_1_Table3_1_N;

                case EnSteelDeliveryCondition.M:
                    return specification.HollowSection ? EN1993_1_1_Table3_1_MH : EN1993_1_1_Table3_1_M;

                case EnSteelDeliveryCondition.Q:
                    if (specification.HollowSection)
                    {
                        throw new ArgumentException("Unable to get EN1993-1-1, Table 3.1 values for Hollow Sections" +
                            "using quenched and tempered delivery condition steel. ");
                    }

                    return EN1993_1_1_Table3_1_Q;

                default:
                    throw new ArgumentException("Unable to get EN1993-1-1, Table 3.1 values for unknown" +
                        $" Delivery Condition: {specification.DeliveryCondition}");
            }
        }

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_AR = new()
        {
            { EnSteelGrade.S235, new Table3_1Properties(235, 360, 215, 360) },
            { EnSteelGrade.S275, new Table3_1Properties(275, 430, 255, 410) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 490, 335, 470) },
            { EnSteelGrade.S450, new Table3_1Properties(440, 550, 410, 550) },
        };

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_N = new()
        {
            { EnSteelGrade.S275, new Table3_1Properties(275, 390, 255, 370) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 490, 335, 470) },
            { EnSteelGrade.S420, new Table3_1Properties(420, 520, 390, 520) },
            { EnSteelGrade.S460, new Table3_1Properties(460, 540, 430, 540) },
        };

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_M = new()
        {
            { EnSteelGrade.S275, new Table3_1Properties(275, 370, 255, 360) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 470, 335, 450) },
            { EnSteelGrade.S420, new Table3_1Properties(420, 520, 390, 500) },
            { EnSteelGrade.S460, new Table3_1Properties(460, 540, 430, 530) },
        };

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_W = new()
        {
            { EnSteelGrade.S235, new Table3_1Properties(235, 360, 215, 340) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 490, 335, 490) },
        };

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_Q = new()
        {
            { EnSteelGrade.S460, new Table3_1Properties(460, 570, 440, 550) },
        };

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_ARH = new()
        {

            { EnSteelGrade.S235, new Table3_1Properties(235, 360, 215, 340) },
            { EnSteelGrade.S275, new Table3_1Properties(275, 430, 255, 410) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 510, 335, 490) },
        };

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_NH = new()
        {
            { EnSteelGrade.S275, new Table3_1Properties(275, 390, 255, 370) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 490, 335, 470) },
            { EnSteelGrade.S420, new Table3_1Properties(420, 540, 390, 520) },
            { EnSteelGrade.S460, new Table3_1Properties(460, 560, 430, 550) },
        };

        private static readonly Dictionary<Enum, Table3_1Properties> EN1993_1_1_Table3_1_MH = new()
        {
            { EnSteelGrade.S275, new Table3_1Properties(275, 360, 0, 0) },
            { EnSteelGrade.S355, new Table3_1Properties(355, 470, 0, 0) },
            { EnSteelGrade.S420, new Table3_1Properties(420, 500, 0, 0) },
            { EnSteelGrade.S460, new Table3_1Properties(460, 530, 0, 0) },
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
