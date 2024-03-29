using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP320x117 : SingletonEuropeanBase<HP320x117>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 320 × 117";
        public Length Height => new Length(311, LengthUnit.Millimeter);
        public Length Width => new Length(308, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HP320x117() { }
    }
}
