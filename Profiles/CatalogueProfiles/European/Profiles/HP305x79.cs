using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP305x79 : SingletonEuropeanBase<HP305x79>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 305 × 79";
        public Length Height => new Length(299.3, LengthUnit.Millimeter);
        public Length Width => new Length(306.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP305x79() { }
    }
}
