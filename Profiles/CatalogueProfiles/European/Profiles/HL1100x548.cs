using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1100x548 : SingletonEuropeanBase<HL1100x548>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 1100 × 548";
        public Length Height => new Length(1128, LengthUnit.Millimeter);
        public Length Width => new Length(407, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(50, LengthUnit.Millimeter);
        public Length WebThickness => new Length(28, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1100x548() { }
    }
}
