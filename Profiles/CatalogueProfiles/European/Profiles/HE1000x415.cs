using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000x415 : SingletonEuropeanBase<HE1000x415>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 1000 × 415";
        public Length Height => new Length(1020, LengthUnit.Millimeter);
        public Length Width => new Length(304, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(46, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000x415() { }
    }
}
