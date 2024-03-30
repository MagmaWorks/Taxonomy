using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x368 : SingletonEuropeanBase<HL920x368>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 368";
        public Length Height => new Length(931, LengthUnit.Millimeter);
        public Length Width => new Length(419, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(34.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x368() { }
    }
}
