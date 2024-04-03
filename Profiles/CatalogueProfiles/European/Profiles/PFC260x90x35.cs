using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC260x90x35 : SingletonEuropeanBase<PFC260x90x35>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 260 × 90 × 35";
        public Length Height => new Length(260, LengthUnit.Millimeter);
        public Length Width => new Length(90, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC260x90x35() { }
    }
}
