using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP254x254x85 : SingletonEuropeanBase<UBP254x254x85>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 254 × 254 × 85";
        public Length Height => new Length(254.3, LengthUnit.Millimeter);
        public Length Width => new Length(260.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UBP254x254x85() { }
    }
}
