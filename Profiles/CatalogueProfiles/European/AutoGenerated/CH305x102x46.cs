using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH305x102x46 : SingletonEuropeanBase<CH305x102x46>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 305 × 102 × 46";
        public Length Height => new Length(304.8, LengthUnit.Millimeter);
        public Length Width => new Length(101.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(26.7, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(13.3, LengthUnit.Millimeter);
        public Length WebHeight => new Length(222, LengthUnit.Millimeter);

        public CH305x102x46() { }
    }
}

