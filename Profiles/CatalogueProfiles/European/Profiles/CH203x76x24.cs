using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH203x76x24 : SingletonEuropeanBase<CH203x76x24>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 203 × 76 × 24";
        public Length Height => new Length(203.2, LengthUnit.Millimeter);
        public Length Width => new Length(76.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(144, LengthUnit.Millimeter);

        public CH203x76x24() { }
    }
}
