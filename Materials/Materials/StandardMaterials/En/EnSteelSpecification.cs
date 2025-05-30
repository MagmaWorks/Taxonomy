namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class EnSteelSpecification : IEnSteelSpecification
    {
        public EnExecutionClass? ExecutionClassforStaticOrLowSeismicLoading { get; set; } = EnExecutionClass.EXC3;
        public EnExecutionClass? ExecutionClassforFatigueOrHighSeismicLoading { get; set; } = EnExecutionClass.EXC3;
        public EnSteelCorrosionResistance CorrosionResistance { get; set; } = EnSteelCorrosionResistance.None;
        public EnSteelDeliveryCondition? DeliveryCondition { get; set; } = EnSteelDeliveryCondition.AR;
        public EnSteelFormingTemperature? FormingTemperature { get; set; } = EnSteelFormingTemperature.HotRolled;
        public EnSteelImpactTemperatureProperty ImpactTemperatureProperty { get; set; } = EnSteelImpactTemperatureProperty.None;
        public EnSteelQuality Quality { get; set; } = EnSteelQuality.None;
        public bool? HollowSection { get; set; } = false;

        internal EnSteelSpecification()
        {
        }

        internal void Validate(EnSteelGrade grade)
        {
            if (CorrosionResistance != EnSteelCorrosionResistance.None)
            {
                switch (DeliveryCondition)
                {
                    case EnSteelDeliveryCondition.AR:
                    case EnSteelDeliveryCondition.N:
                        if (ImpactTemperatureProperty != EnSteelImpactTemperatureProperty.None)
                        {
                            throw new InvalidSteelSpecificationException(
                                $"Low impact temperature property (L) may not be used in accordance with EN 10025-5, " +
                                $"structural steels with improved atmospheric corrosion resistance.");
                        }

                        switch (grade)
                        {
                            case EnSteelGrade.S235:
                                if (CorrosionResistance == EnSteelCorrosionResistance.WP)
                                {
                                    throw new InvalidSteelSpecificationException(
                                        $"Improved atmospheric corrosion resistance class WP may only be used for steel grade " +
                                        $"S355 in accordance with EN 10025-5");
                                }
                                break;

                            case EnSteelGrade.S355:
                                break;

                            default:
                                throw new InvalidSteelSpecificationException(
                                    $"Only steel grades S235 and S355 may be used in accordance with EN 10025-5, " +
                                    $"for Improved atmospheric corrosion resistance.");
                        }
                        break;

                    default:
                        throw new InvalidSteelSpecificationException(
                            $"In accordance with EN 10025-5, structural steels with improved " +
                            $"atmospheric corrosion resistance class {CorrosionResistance} may only be delivered " +
                            $"with normalized rolling (+N) or as-rolled (+AR).");
                }
            }

            if (ImpactTemperatureProperty == EnSteelImpactTemperatureProperty.L1)
            {
                if (!(grade == EnSteelGrade.S460 && DeliveryCondition == EnSteelDeliveryCondition.Q))
                {
                    throw new InvalidSteelSpecificationException(
                        $"Only steel grades S460 in quenched and tempered delivery condition according to EN 10025-5, " +
                        $"may use L1 designation for minimum values of impact energy at low temperatures");
                }
            }

            switch (DeliveryCondition)
            {
                case EnSteelDeliveryCondition.AR:
                    switch (grade)
                    {
                        case EnSteelGrade.S235:
                        case EnSteelGrade.S275:
                        case EnSteelGrade.S355:
                            break;

                        case EnSteelGrade.S450:
                            if (HollowSection != null && (bool)HollowSection)
                            {
                                throw new InvalidSteelSpecificationException(
                                    $"Steel grade {grade} is not covered by EN 10210-1 " +
                                    $"and EN 1993-1-1, Table 3.1 for hollow sections");
                            }
                            break;

                        default:
                            throw new InvalidSteelSpecificationException(
                                $"Steel grade {grade} is not covered by EN 10025-2 " +
                                $"for as-rolled (+AR) delivery condition");
                    }
                    break;

                case EnSteelDeliveryCondition.N:
                    switch (grade)
                    {
                        case EnSteelGrade.S275:
                        case EnSteelGrade.S355:
                        case EnSteelGrade.S420:
                        case EnSteelGrade.S460:
                            break;

                        default:
                            throw new InvalidSteelSpecificationException(
                                $"Steel grade {grade} is not covered byEN 10025-3 " +
                                $"for Normalized/normalized rolled (N) delivery condition");
                    }
                    break;

                case EnSteelDeliveryCondition.M:
                    switch (grade)
                    {
                        case EnSteelGrade.S275:
                        case EnSteelGrade.S355:
                        case EnSteelGrade.S420:
                        case EnSteelGrade.S460:
                            break;

                        default:
                            throw new InvalidSteelSpecificationException(
                                $"Steel grade {grade} is not covered byEN 10025-3 " +
                                $"for thermomechanical rolled (M) delivery condition");
                    }
                    break;

                case EnSteelDeliveryCondition.Q:
                    if (grade != EnSteelGrade.S460)
                    {
                        throw new InvalidSteelSpecificationException(
                            $"Only steel grade S460 is covered by EN 10025-6 and EN1993-1-1, Table 3.1.");
                    }

                    if (HollowSection != null && (bool)HollowSection)
                    {
                        throw new InvalidSteelSpecificationException(
                            $"Quenched and tempered delivery condition (Q) according to EN 10025-6 " +
                            $"is not covered by EN 1993-1-1, Table 3.1 for hollow sections");
                    }
                    break;

                default:
                    throw new InvalidSteelSpecificationException(
                        $"Unable to validate steel specification for delivery " +
                        $"condition {DeliveryCondition}.");
            }
        }

        internal string GetShortDesignation(EnSteelGrade grade)
        {
            Validate(grade);
            string j0 = Quality.ToString();
            string w = CorrosionResistance.ToString();
            string n = DeliveryCondition.ToString();
            if (DeliveryCondition == EnSteelDeliveryCondition.AR)
            {
                n = "+" + n;
            }

            string l = ImpactTemperatureProperty.ToString();
            string h = (HollowSection != null && (bool)HollowSection) ? "H" : string.Empty;
            string description = (j0 + w + n + l + h).Replace("None", string.Empty);
            if (CorrosionResistance != EnSteelCorrosionResistance.None)
            {
                if (DeliveryCondition == EnSteelDeliveryCondition.N)
                {
                    n = "+" + n;
                    description = (j0 + w + n + l + h).Replace("None", string.Empty);
                }
            }

            return $"{grade}{description}";
        }

        internal string GetCodeDesignation(EnSteelGrade grade)
        {
            string designation = GetShortDesignation(grade);
            if (CorrosionResistance != EnSteelCorrosionResistance.None)
            {
                return $"Steel EN 10025-5 - {designation}";
            }

            switch (DeliveryCondition)
            {
                case EnSteelDeliveryCondition.AR:
                    return $"Steel EN 10025-2 - {designation}";

                case EnSteelDeliveryCondition.N:
                    return $"Steel EN 10025-3 - {designation}";

                case EnSteelDeliveryCondition.M:
                    return $"Steel EN 10025-4 - {designation}";

                case EnSteelDeliveryCondition.Q:
                    return $"Steel EN 10025-6 - {designation}";

                default:
                    return $"Steel EN 10025 - {designation}";
            }
        }
    }
}
