using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC300x100x46 : SingletonEuropeanBase<PFC300x100x46>, IChannelParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.PFC;
        public override string Designation => "PFC 300 × 100 × 46";
        public Length Height => new Length(300, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public PFC300x100x46() { }
    }
}

