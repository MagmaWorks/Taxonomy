using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000x748 : SingletonEuropeanBase<HL1000x748>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 1000 × 748";
        public Length Height => new Length(1068, LengthUnit.Millimeter);
        public Length Width => new Length(417, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(70, LengthUnit.Millimeter);
        public Length WebThickness => new Length(39, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000x748() { }
    }
}
