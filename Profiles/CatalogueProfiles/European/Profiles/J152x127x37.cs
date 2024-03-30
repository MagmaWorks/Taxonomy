using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J152x127x37 : SingletonEuropeanBase<J152x127x37>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.J;
        public override string Designation => "J 152 × 127 × 37";
        public Length Height => new Length(152.4, LengthUnit.Millimeter);
        public Length Width => new Length(127, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(126, LengthUnit.Millimeter);

        public J152x127x37() { }
    }
}
