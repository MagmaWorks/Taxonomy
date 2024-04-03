using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEV550 : SingletonEuropeanBase<IPEV550>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEV;
        public override string Label => "IPE V 550";
        public Length Height => new Length(566, LengthUnit.Millimeter);
        public Length Width => new Length(216, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPEV550() { }
    }
}
