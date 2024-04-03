using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB1016x305x438 : SingletonEuropeanBase<UB1016x305x438>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 1016 × 305 × 438";
        public Length Height => new Length(1026, LengthUnit.Millimeter);
        public Length Width => new Length(305, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(49, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public UB1016x305x438() { }
    }
}
