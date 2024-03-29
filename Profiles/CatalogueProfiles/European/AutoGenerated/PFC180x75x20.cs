using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC180x75x20 : SingletonEuropeanBase<PFC180x75x20>, IChannelParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.PFC;
        public override string Designation => "PFC 180 × 75 × 20";
        public Length Height => new Length(180, LengthUnit.Millimeter);
        public Length Width => new Length(75, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC180x75x20() { }
    }
}
