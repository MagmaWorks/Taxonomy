using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA160 : SingletonEuropeanBase<IPEAA160>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEAA;
        public override string Label => "IPE AA 160";
        public Length Height => new Length(156.4, LengthUnit.Millimeter);
        public Length Width => new Length(82, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public IPEAA160() { }
    }
}
