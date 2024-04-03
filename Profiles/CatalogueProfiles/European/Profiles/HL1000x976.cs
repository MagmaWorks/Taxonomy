using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000x976 : SingletonEuropeanBase<HL1000x976>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 × 976";
        public Length Height => new Length(1108, LengthUnit.Millimeter);
        public Length Width => new Length(428, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(89.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(50, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000x976() { }
    }
}
