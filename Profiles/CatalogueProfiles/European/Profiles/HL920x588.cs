using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x588 : SingletonEuropeanBase<HL920x588>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 588";
        public Length Height => new Length(975, LengthUnit.Millimeter);
        public Length Width => new Length(427, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(55.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(31, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x588() { }
    }
}
