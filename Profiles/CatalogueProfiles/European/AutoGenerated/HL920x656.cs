using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x656 : SingletonEuropeanBase<HL920x656>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 920 × 656";
        public Length Height => new Length(987, LengthUnit.Millimeter);
        public Length Width => new Length(431, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(62, LengthUnit.Millimeter);
        public Length WebThickness => new Length(34.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x656() { }
    }
}
