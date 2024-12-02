using System;
using System.Diagnostics;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class EnSteelMaterial : IEnSteelMaterial
    {
        public EnSteelGrade Grade { get; set; } = EnSteelGrade.S355;
        public IEnSteelSpecification Specification { get; set; } = new EnSteelSpecification();
        public IEurocode Standard { get; set; } = new En1993(En1993Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Steel;
        public Ratio PartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio MemberInstabilityPartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio TensionFracturePartialFactor { get; set; } = new Ratio(1.25, RatioUnit.DecimalFraction);

        public EnSteelMaterial(EnSteelGrade grade, NationalAnnex nationalAnnex)
        {
            Grade = grade;
            Standard = new En1993(En1993Part.Part1_1, nationalAnnex);
            SetPartialFactors(nationalAnnex);
        }

        public static bool TryCastFromString(string steel, NationalAnnex nationalAnnex, out EnSteelMaterial material)
        {
            material = null;
            string s = steel.Trim().ToLower();
            if (Enum.TryParse(s.Substring(0, 4), true, out EnSteelGrade grade))
            {
                return false;
            }

            material = new EnSteelMaterial(grade, nationalAnnex);
            if (steel.Contains("n"))
            {
                material.Specification.DeliveryCondition = EnSteelDeliveryCondition.N;
            }

            if (steel.Contains("m"))
            {
                material.Specification.DeliveryCondition = EnSteelDeliveryCondition.M;
            }

            if (steel.Contains("q"))
            {
                material.Specification.DeliveryCondition = EnSteelDeliveryCondition.Q;
            }

            if (steel.Contains("h"))
            {
                material.Specification.HollowSection = true;
            }

            if (steel.Contains("w"))
            {
                material.Specification.CorrosionResistance = EnSteelCorrosionResistance.W;
            }

            if (steel.Contains("wp"))
            {
                material.Specification.CorrosionResistance = EnSteelCorrosionResistance.WP;
            }

            if (steel.Contains("l"))
            {
                material.Specification.ImpactTemperatureProperty = EnSteelImpactTemperatureProperty.L;
            }

            if (steel.Contains("l1"))
            {
                material.Specification.ImpactTemperatureProperty = EnSteelImpactTemperatureProperty.L1;
            }

            if (steel.Contains("jr"))
            {
                material.Specification.Quality = EnSteelQuality.JR;
            }

            if (steel.Contains("j0"))
            {
                material.Specification.Quality = EnSteelQuality.J0;
            }

            if (steel.Contains("j2"))
            {
                material.Specification.Quality = EnSteelQuality.J2;
            }

            if (steel.Contains("k2"))
            {
                material.Specification.Quality = EnSteelQuality.K2;
            }

            return true;
        }

        private void SetPartialFactors(NationalAnnex nationalAnnex)
        {
            switch (nationalAnnex)
            {
                case NationalAnnex.RecommendedValues:
                    break;

                case NationalAnnex.UnitedKingdom:
                    TensionFracturePartialFactor = new Ratio(1.1, RatioUnit.DecimalFraction);
                    break;

                case NationalAnnex.Germany:
                    MemberInstabilityPartialFactor = new Ratio(1.1, RatioUnit.DecimalFraction);
                    break;

                default:
                    throw new MissingNationalAnnexException(nationalAnnex);
            }
        }
    }
}
