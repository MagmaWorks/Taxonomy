using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP360x180 : SingletonEuropeanBase<HP360x180>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 360 × 180";
        public Length Height => new Length(362.9, LengthUnit.Millimeter);
        public Length Width => new Length(378.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP360x180() { }
    }
}

