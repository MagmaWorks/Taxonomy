using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC230x75x26 : SingletonEuropeanBase<PFC230x75x26>, IChannelParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.PFC;
        public override string Designation => "PFC 230 × 75 × 26";
        public Length Height => new Length(230, LengthUnit.Millimeter);
        public Length Width => new Length(75, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC230x75x26() { }
    }
}

