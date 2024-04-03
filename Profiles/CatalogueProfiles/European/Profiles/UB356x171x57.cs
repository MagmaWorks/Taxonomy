using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB356x171x57 : SingletonEuropeanBase<UB356x171x57>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 356 × 171 × 57";
        public Length Height => new Length(358, LengthUnit.Millimeter);
        public Length Width => new Length(172.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB356x171x57() { }
    }
}
