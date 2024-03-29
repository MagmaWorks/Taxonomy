using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH381x102x55 : SingletonEuropeanBase<CH381x102x55>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 381 × 102 × 55";
        public Length Height => new Length(381, LengthUnit.Millimeter);
        public Length Width => new Length(101.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(28.2, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(14.1, LengthUnit.Millimeter);
        public Length WebHeight => new Length(292, LengthUnit.Millimeter);

        public CH381x102x55() { }
    }
}
