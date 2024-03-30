using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x537 : SingletonEuropeanBase<HL920x537>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 537";
        public Length Height => new Length(965, LengthUnit.Millimeter);
        public Length Width => new Length(425, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(51.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(28.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x537() { }
    }
}
