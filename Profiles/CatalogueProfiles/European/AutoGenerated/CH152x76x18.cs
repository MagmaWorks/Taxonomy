using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH152x76x18 : SingletonEuropeanBase<CH152x76x18>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 152 × 76 × 18";
        public Length Height => new Length(152.4, LengthUnit.Millimeter);
        public Length Width => new Length(76.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(14, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(103, LengthUnit.Millimeter);

        public CH152x76x18() { }
    }
}

