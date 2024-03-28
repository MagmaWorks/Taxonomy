using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH76x38x7 : SingletonEuropeanBase<CH76x38x7>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 76 × 38 × 7";
        public Length Height => new Length(76.2, LengthUnit.Millimeter);
        public Length Width => new Length(38.1, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6, LengthUnit.Millimeter);
        public Length WebHeight => new Length(38.2, LengthUnit.Millimeter);

        public CH76x38x7() { }
    }
}

