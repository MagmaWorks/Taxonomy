using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP254x254x63 : SingletonEuropeanBase<UBP254x254x63>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 254 × 254 × 63";
        public Length Height => new Length(247.1, LengthUnit.Millimeter);
        public Length Width => new Length(256.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UBP254x254x63() { }
    }
}
