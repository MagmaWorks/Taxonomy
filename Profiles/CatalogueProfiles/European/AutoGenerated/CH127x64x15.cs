using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH127x64x15 : SingletonEuropeanBase<CH127x64x15>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 127 × 64 × 15";
        public Length Height => new Length(127, LengthUnit.Millimeter);
        public Length Width => new Length(63.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(80.5, LengthUnit.Millimeter);

        public CH127x64x15() { }
    }
}

