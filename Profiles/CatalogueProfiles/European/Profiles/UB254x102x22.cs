using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB254x102x22 : SingletonEuropeanBase<UB254x102x22>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 254 × 102 × 22";
        public Length Height => new Length(254, LengthUnit.Millimeter);
        public Length Width => new Length(101.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB254x102x22() { }
    }
}
