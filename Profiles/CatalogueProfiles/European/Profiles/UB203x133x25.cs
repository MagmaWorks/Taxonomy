using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB203x133x25 : SingletonEuropeanBase<UB203x133x25>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 203 × 133 × 25";
        public Length Height => new Length(203.2, LengthUnit.Millimeter);
        public Length Width => new Length(133.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB203x133x25() { }
    }
}
