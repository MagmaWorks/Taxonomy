using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH254x76x28 : SingletonEuropeanBase<CH254x76x28>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 254 × 76 × 28";
        public Length Height => new Length(254, LengthUnit.Millimeter);
        public Length Width => new Length(76.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(9.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(192, LengthUnit.Millimeter);

        public CH254x76x28() { }
    }
}

