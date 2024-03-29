using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J203x152x52 : SingletonEuropeanBase<J203x152x52>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.J;
        public override string Designation => "J 203 × 152 × 52";
        public Length Height => new Length(203.2, LengthUnit.Millimeter);
        public Length Width => new Length(152.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(7.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(135, LengthUnit.Millimeter);

        public J203x152x52() { }
    }
}
