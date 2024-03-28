using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x970 : SingletonEuropeanBase<HL920x970>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 920 × 970";
        public Length Height => new Length(1043, LengthUnit.Millimeter);
        public Length Width => new Length(446, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(89.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(50, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x970() { }
    }
}

