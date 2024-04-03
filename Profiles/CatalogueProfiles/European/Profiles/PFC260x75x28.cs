using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC260x75x28 : SingletonEuropeanBase<PFC260x75x28>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 260 × 75 × 28";
        public Length Height => new Length(260, LengthUnit.Millimeter);
        public Length Width => new Length(75, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC260x75x28() { }
    }
}
