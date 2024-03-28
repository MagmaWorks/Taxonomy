using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class U50x25x5 : SingletonEuropeanBase<U50x25x5>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.U;
        public override string Designation => "U 50 × 25 × 5";
        public Length Height => new Length(50, LengthUnit.Millimeter);
        public Length Width => new Length(25, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(6, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(3, LengthUnit.Millimeter);
        public Length WebHeight => new Length(25.7, LengthUnit.Millimeter);

        public U50x25x5() { }
    }
}

