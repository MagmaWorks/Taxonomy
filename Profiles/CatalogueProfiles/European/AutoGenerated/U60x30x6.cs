using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class U60x30x6 : SingletonEuropeanBase<U60x30x6>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.U;
        public override string Designation => "U 60 × 30 × 6";
        public Length Height => new Length(60, LengthUnit.Millimeter);
        public Length Width => new Length(30, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(6, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(3, LengthUnit.Millimeter);
        public Length WebHeight => new Length(34.9, LengthUnit.Millimeter);

        public U60x30x6() { }
    }
}

