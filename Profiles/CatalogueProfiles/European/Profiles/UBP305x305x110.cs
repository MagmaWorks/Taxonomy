using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP305x305x110 : SingletonEuropeanBase<UBP305x305x110>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 305 × 305 × 110";
        public Length Height => new Length(307.9, LengthUnit.Millimeter);
        public Length Width => new Length(310.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP305x305x110() { }
    }
}
