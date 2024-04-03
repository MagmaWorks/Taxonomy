using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x127x42 : SingletonEuropeanBase<UB305x127x42>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 305 × 127 × 42";
        public Length Height => new Length(307.2, LengthUnit.Millimeter);
        public Length Width => new Length(124.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.9, LengthUnit.Millimeter);

        public UB305x127x42() { }
    }
}
