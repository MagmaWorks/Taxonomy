using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class U40x20x4 : SingletonEuropeanBase<U40x20x4>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.U;
        public override string Designation => "U 40 × 20 × 4";
        public Length Height => new Length(40, LengthUnit.Millimeter);
        public Length Width => new Length(20, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(5.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(2.2, LengthUnit.Millimeter);
        public Length WebHeight => new Length(19, LengthUnit.Millimeter);

        public U40x20x4() { }
    }
}

