using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000B : SingletonEuropeanBase<HL1000B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 B";
        public Length Height => new Length(1000, LengthUnit.Millimeter);
        public Length Width => new Length(400, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(36.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000B() { }
    }
}
