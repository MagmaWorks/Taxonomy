using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x127x48 : SingletonEuropeanBase<UB305x127x48>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 305 × 127 × 48";
        public Length Height => new Length(311, LengthUnit.Millimeter);
        public Length Width => new Length(125.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.9, LengthUnit.Millimeter);

        public UB305x127x48() { }
    }
}
