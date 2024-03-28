using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x1077 : SingletonEuropeanBase<HL920x1077>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 920 × 1077";
        public Length Height => new Length(1061, LengthUnit.Millimeter);
        public Length Width => new Length(451, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(99.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(55, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x1077() { }
    }
}

