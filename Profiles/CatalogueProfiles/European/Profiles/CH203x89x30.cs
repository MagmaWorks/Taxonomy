using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH203x89x30 : SingletonEuropeanBase<CH203x89x30>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 203 × 89 × 30";
        public Length Height => new Length(203.2, LengthUnit.Millimeter);
        public Length Width => new Length(88.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(139, LengthUnit.Millimeter);

        public CH203x89x30() { }
    }
}
