using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH178x76x21 : SingletonEuropeanBase<CH178x76x21>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 178 × 76 × 21";
        public Length Height => new Length(177.8, LengthUnit.Millimeter);
        public Length Width => new Length(76.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(16, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(123, LengthUnit.Millimeter);

        public CH178x76x21() { }
    }
}

