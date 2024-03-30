using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x419x388 : SingletonEuropeanBase<UB914x419x388>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 419 × 388";
        public Length Height => new Length(921, LengthUnit.Millimeter);
        public Length Width => new Length(420.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(36.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x419x388() { }
    }
}
