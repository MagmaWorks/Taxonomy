using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1100x607 : SingletonEuropeanBase<HL1100x607>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1100 × 607";
        public Length Height => new Length(1138, LengthUnit.Millimeter);
        public Length Width => new Length(410, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(55, LengthUnit.Millimeter);
        public Length WebThickness => new Length(31, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1100x607() { }
    }
}
