using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA400 : SingletonEuropeanBase<IPEA400>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 400";
        public Length Height => new Length(397, LengthUnit.Millimeter);
        public Length Width => new Length(180, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEA400() { }
    }
}
