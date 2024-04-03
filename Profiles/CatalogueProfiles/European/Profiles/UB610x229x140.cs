using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB610x229x140 : SingletonEuropeanBase<UB610x229x140>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 610 × 229 × 140";
        public Length Height => new Length(617.2, LengthUnit.Millimeter);
        public Length Width => new Length(230.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(22.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB610x229x140() { }
    }
}
