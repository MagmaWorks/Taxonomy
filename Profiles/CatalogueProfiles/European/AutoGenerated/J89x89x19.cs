using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J89x89x19 : SingletonEuropeanBase<J89x89x19>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.J;
        public override string Designation => "J 89 × 89 × 19";
        public Length Height => new Length(88.9, LengthUnit.Millimeter);
        public Length Width => new Length(88.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(11.1, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(69.1, LengthUnit.Millimeter);

        public J89x89x19() { }
    }
}
