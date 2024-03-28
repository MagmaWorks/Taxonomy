using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB127x76x13 : SingletonEuropeanBase<UB127x76x13>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 127 × 76 × 13";
        public Length Height => new Length(127, LengthUnit.Millimeter);
        public Length Width => new Length(76, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB127x76x13() { }
    }
}

