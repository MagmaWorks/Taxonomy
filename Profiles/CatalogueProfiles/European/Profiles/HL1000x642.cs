using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000x642 : SingletonEuropeanBase<HL1000x642>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 × 642";
        public Length Height => new Length(1048, LengthUnit.Millimeter);
        public Length Width => new Length(412, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(60, LengthUnit.Millimeter);
        public Length WebThickness => new Length(34, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000x642() { }
    }
}
