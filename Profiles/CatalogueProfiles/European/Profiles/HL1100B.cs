using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1100B : SingletonEuropeanBase<HL1100B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1100 B";
        public Length Height => new Length(1100, LengthUnit.Millimeter);
        public Length Width => new Length(400, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(36, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1100B() { }
    }
}
