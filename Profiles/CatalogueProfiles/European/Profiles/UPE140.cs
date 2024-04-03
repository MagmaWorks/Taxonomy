using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE140 : SingletonEuropeanBase<UPE140>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 140";
        public Length Height => new Length(140, LengthUnit.Millimeter);
        public Length Width => new Length(65, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public UPE140() { }
    }
}
