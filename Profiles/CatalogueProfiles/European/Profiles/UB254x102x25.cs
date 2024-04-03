using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB254x102x25 : SingletonEuropeanBase<UB254x102x25>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 254 × 102 × 25";
        public Length Height => new Length(257.2, LengthUnit.Millimeter);
        public Length Width => new Length(101.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB254x102x25() { }
    }
}
