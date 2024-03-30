using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP305x305x126 : SingletonEuropeanBase<UBP305x305x126>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 305 × 305 × 126";
        public Length Height => new Length(312.3, LengthUnit.Millimeter);
        public Length Width => new Length(312.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP305x305x126() { }
    }
}
