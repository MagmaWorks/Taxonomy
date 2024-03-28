using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J254x203x82 : SingletonEuropeanBase<J254x203x82>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.J;
        public override string Designation => "J 254 × 203 × 82";
        public Length Height => new Length(254, LengthUnit.Millimeter);
        public Length Width => new Length(203.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(10.7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(166, LengthUnit.Millimeter);

        public J254x203x82() { }
    }
}

