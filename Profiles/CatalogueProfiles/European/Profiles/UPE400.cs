using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE400 : SingletonEuropeanBase<UPE400>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 400";
        public Length Height => new Length(400, LengthUnit.Millimeter);
        public Length Width => new Length(115, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public UPE400() { }
    }
}
