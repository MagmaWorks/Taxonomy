using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA360 : SingletonEuropeanBase<IPEA360>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 360";
        public Length Height => new Length(357.6, LengthUnit.Millimeter);
        public Length Width => new Length(170, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public IPEA360() { }
    }
}
