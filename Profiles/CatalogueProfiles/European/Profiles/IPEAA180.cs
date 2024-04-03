using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA180 : SingletonEuropeanBase<IPEAA180>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEAA;
        public override string Label => "IPE AA 180";
        public Length Height => new Length(176.4, LengthUnit.Millimeter);
        public Length Width => new Length(91, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public IPEAA180() { }
    }
}
