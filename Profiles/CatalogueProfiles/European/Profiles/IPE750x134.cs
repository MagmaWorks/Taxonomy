using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE750x134 : SingletonEuropeanBase<IPE750x134>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 750 × 134";
        public Length Height => new Length(750, LengthUnit.Millimeter);
        public Length Width => new Length(264, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public IPE750x134() { }
    }
}
