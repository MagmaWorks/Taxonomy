using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE220M : SingletonEuropeanBase<HE220M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 220 M";
        public Length Height => new Length(240, LengthUnit.Millimeter);
        public Length Width => new Length(226, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(26, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE220M() { }
    }
}
