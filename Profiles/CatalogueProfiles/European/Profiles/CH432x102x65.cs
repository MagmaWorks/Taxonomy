using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH432x102x65 : SingletonEuropeanBase<CH432x102x65>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 432 × 102 × 65";
        public Length Height => new Length(431.8, LengthUnit.Millimeter);
        public Length Width => new Length(101.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(12, LengthUnit.Millimeter);
        public Length WebHeight => new Length(350, LengthUnit.Millimeter);

        public CH432x102x65() { }
    }
}
