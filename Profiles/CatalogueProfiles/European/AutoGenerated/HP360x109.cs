using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP360x109 : SingletonEuropeanBase<HP360x109>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 360 × 109";
        public Length Height => new Length(346.4, LengthUnit.Millimeter);
        public Length Width => new Length(371, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP360x109() { }
    }
}

