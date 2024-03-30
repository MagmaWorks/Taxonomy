using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA120 : SingletonEuropeanBase<IPEA120>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 120";
        public Length Height => new Length(117.6, LengthUnit.Millimeter);
        public Length Width => new Length(64, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPEA120() { }
    }
}
