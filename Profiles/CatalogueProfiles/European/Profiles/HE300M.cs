using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE300M : SingletonEuropeanBase<HE300M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 300 M";
        public Length Height => new Length(340, LengthUnit.Millimeter);
        public Length Width => new Length(310, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(39, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE300M() { }
    }
}
