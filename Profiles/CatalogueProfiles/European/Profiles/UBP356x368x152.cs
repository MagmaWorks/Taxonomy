using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP356x368x152 : SingletonEuropeanBase<UBP356x368x152>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 356 × 368 × 152";
        public Length Height => new Length(356.4, LengthUnit.Millimeter);
        public Length Width => new Length(376, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP356x368x152() { }
    }
}
