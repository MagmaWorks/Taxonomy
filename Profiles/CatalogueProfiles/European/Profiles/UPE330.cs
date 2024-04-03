using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE330 : SingletonEuropeanBase<UPE330>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 330";
        public Length Height => new Length(330, LengthUnit.Millimeter);
        public Length Width => new Length(105, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public UPE330() { }
    }
}
