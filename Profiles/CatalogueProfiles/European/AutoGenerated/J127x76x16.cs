using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J127x76x16 : SingletonEuropeanBase<J127x76x16>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.J;
        public override string Designation => "J 127 × 76 × 16";
        public Length Height => new Length(127, LengthUnit.Millimeter);
        public Length Width => new Length(76.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(107.8, LengthUnit.Millimeter);

        public J127x76x16() { }
    }
}
