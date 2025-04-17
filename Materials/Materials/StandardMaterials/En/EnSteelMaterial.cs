using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class EnSteelMaterial : IEnSteelMaterial
    {
        public EnSteelGrade Grade { get; set; } = EnSteelGrade.S355;
        public IEnSteelSpecification Specification { get; } = new EnSteelSpecification();
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

        public static bool TryCreateFromDesignition(string designition, NationalAnnex nationalAnnex, out EnSteelMaterial material)
        {
            material = null;
            string s = designition.Replace(" ", string.Empty).ToLower();
            if (!Enum.TryParse(s.Substring(0, 4), true, out EnSteelGrade grade))
            {
                return false;
            }

            material = new EnSteelMaterial(grade, nationalAnnex);
            if (s.Contains("n"))
            {
                material.Specification.DeliveryCondition = EnSteelDeliveryCondition.N;
            }

            if (s.Contains("m"))
            {
                material.Specification.DeliveryCondition = EnSteelDeliveryCondition.M;
            }

            if (s.Contains("q"))
            {
                material.Specification.DeliveryCondition = EnSteelDeliveryCondition.Q;
            }

            if (s.Contains("h"))
            {
                material.Specification.HollowSection = true;
            }

            if (s.Contains("w"))
            {
                material.Specification.CorrosionResistance = EnSteelCorrosionResistance.W;
            }

            if (s.Contains("wp"))
            {
                material.Specification.CorrosionResistance = EnSteelCorrosionResistance.WP;
            }

            if (s.Contains("l"))
            {
                material.Specification.ImpactTemperatureProperty = EnSteelImpactTemperatureProperty.L;
            }

            if (s.Contains("l1"))
            {
                material.Specification.ImpactTemperatureProperty = EnSteelImpactTemperatureProperty.L1;
            }

            if (s.Contains("jr"))
            {
                material.Specification.Quality = EnSteelQuality.JR;
            }

            if (s.Contains("j0"))
            {
                material.Specification.Quality = EnSteelQuality.J0;
            }

            if (s.Contains("j2"))
            {
                material.Specification.Quality = EnSteelQuality.J2;
            }

            if (s.Contains("k2"))
            {
                material.Specification.Quality = EnSteelQuality.K2;
            }

            try
            {
                ((EnSteelSpecification)material.Specification).Validate(grade);
                return true;
            }
            catch (InvalidSteelSpecificationException)
            {
                return false;
            }
        }

        public string GetShortDesignation()
        {
            return ((EnSteelSpecification)Specification).GetShortDesignation(Grade);
        }

        public string GetCodeDesignation()
        {
            return ((EnSteelSpecification)Specification).GetCodeDesignation(Grade);
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
