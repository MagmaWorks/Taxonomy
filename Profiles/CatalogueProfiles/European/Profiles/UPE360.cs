using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE360 : SingletonEuropeanBase<UPE360>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 360";
        public Length Height => new Length(360, LengthUnit.Millimeter);
        public Length Width => new Length(110, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public UPE360() { }
    }
}
