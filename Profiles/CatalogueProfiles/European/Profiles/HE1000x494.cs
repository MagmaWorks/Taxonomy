using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000x494 : SingletonEuropeanBase<HE1000x494>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 1000 × 494";
        public Length Height => new Length(1036, LengthUnit.Millimeter);
        public Length Width => new Length(309, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(54, LengthUnit.Millimeter);
        public Length WebThickness => new Length(31, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000x494() { }
    }
}
