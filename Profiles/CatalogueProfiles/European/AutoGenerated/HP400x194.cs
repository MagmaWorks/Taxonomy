using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP400x194 : SingletonEuropeanBase<HP400x194>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 400 × 194";
        public Length Height => new Length(364, LengthUnit.Millimeter);
        public Length Width => new Length(398, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(22, LengthUnit.Millimeter);
        public Length WebThickness => new Length(22, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.2, LengthUnit.Millimeter);

        public HP400x194() { }
    }
}

