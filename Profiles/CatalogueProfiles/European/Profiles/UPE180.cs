using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE180 : SingletonEuropeanBase<UPE180>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 180";
        public Length Height => new Length(180, LengthUnit.Millimeter);
        public Length Width => new Length(75, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public UPE180() { }
    }
}
