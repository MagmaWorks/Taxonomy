using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH102x51x10 : SingletonEuropeanBase<CH102x51x10>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.CH;
        public override string Designation => "CH 102 × 51 × 10";
        public Length Height => new Length(101.6, LengthUnit.Millimeter);
        public Length Width => new Length(50.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6, LengthUnit.Millimeter);
        public Length WebHeight => new Length(61.2, LengthUnit.Millimeter);

        public CH102x51x10() { }
    }
}

