using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x491 : SingletonEuropeanBase<HL920x491>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 491";
        public Length Height => new Length(957, LengthUnit.Millimeter);
        public Length Width => new Length(422, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(47, LengthUnit.Millimeter);
        public Length WebThickness => new Length(25.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x491() { }
    }
}
