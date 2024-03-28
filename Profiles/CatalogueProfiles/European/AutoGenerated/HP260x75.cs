using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP260x75 : SingletonEuropeanBase<HP260x75>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 260 × 75";
        public Length Height => new Length(249, LengthUnit.Millimeter);
        public Length Width => new Length(265, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HP260x75() { }
    }
}

