using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x390 : SingletonEuropeanBase<HL920x390>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 920 × 390";
        public Length Height => new Length(936, LengthUnit.Millimeter);
        public Length Width => new Length(420, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(36.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x390() { }
    }
}

