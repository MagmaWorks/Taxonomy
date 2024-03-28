using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC150x75x18 : SingletonEuropeanBase<PFC150x75x18>, IChannelParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.PFC;
        public override string Designation => "PFC 150 × 75 × 18";
        public Length Height => new Length(150, LengthUnit.Millimeter);
        public Length Width => new Length(75, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC150x75x18() { }
    }
}

