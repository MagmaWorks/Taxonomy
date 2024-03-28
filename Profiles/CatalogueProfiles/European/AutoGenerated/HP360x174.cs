using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP360x174 : SingletonEuropeanBase<HP360x174>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 360 × 174";
        public Length Height => new Length(361.4, LengthUnit.Millimeter);
        public Length Width => new Length(378.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP360x174() { }
    }
}

