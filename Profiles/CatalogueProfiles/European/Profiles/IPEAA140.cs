using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA140 : SingletonEuropeanBase<IPEAA140>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEAA;
        public override string Label => "IPE AA 140";
        public Length Height => new Length(136.6, LengthUnit.Millimeter);
        public Length Width => new Length(73, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPEAA140() { }
    }
}
