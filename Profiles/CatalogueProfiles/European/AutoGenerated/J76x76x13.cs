using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J76x76x13 : SingletonEuropeanBase<J76x76x13>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.J;
        public override string Designation => "J 76 × 76 × 13";
        public Length Height => new Length(76.2, LengthUnit.Millimeter);
        public Length Width => new Length(76.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(59.4, LengthUnit.Millimeter);

        public J76x76x13() { }
    }
}
