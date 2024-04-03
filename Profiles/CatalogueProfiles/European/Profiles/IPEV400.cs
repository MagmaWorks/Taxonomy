using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEV400 : SingletonEuropeanBase<IPEV400>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEV;
        public override string Label => "IPE V 400";
        public Length Height => new Length(408, LengthUnit.Millimeter);
        public Length Width => new Length(182, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEV400() { }
    }
}
