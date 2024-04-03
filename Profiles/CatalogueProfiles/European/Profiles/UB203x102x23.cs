using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB203x102x23 : SingletonEuropeanBase<UB203x102x23>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 203 × 102 × 23";
        public Length Height => new Length(203.2, LengthUnit.Millimeter);
        public Length Width => new Length(101.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB203x102x23() { }
    }
}
