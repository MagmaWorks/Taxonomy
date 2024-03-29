using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP400x158 : SingletonEuropeanBase<HP400x158>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 400 × 158";
        public Length Height => new Length(356, LengthUnit.Millimeter);
        public Length Width => new Length(394, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.2, LengthUnit.Millimeter);

        public HP400x158() { }
    }
}
