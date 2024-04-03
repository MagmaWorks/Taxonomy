using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB686x254x140 : SingletonEuropeanBase<UB686x254x140>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 686 × 254 × 140";
        public Length Height => new Length(683.5, LengthUnit.Millimeter);
        public Length Width => new Length(253.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UB686x254x140() { }
    }
}
