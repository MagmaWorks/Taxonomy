using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1100R : SingletonEuropeanBase<HL1100R>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 1100 R";
        public Length Height => new Length(1118, LengthUnit.Millimeter);
        public Length Width => new Length(405, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(45, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1100R() { }
    }
}

