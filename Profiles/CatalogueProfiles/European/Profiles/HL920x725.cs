using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x725 : SingletonEuropeanBase<HL920x725>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 725";
        public Length Height => new Length(999, LengthUnit.Millimeter);
        public Length Width => new Length(434, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(68.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(38.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x725() { }
    }
}
