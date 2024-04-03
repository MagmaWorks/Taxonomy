using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA200 : SingletonEuropeanBase<IPEA200>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 200";
        public Length Height => new Length(197, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public IPEA200() { }
    }
}
