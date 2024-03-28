using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP305x223 : SingletonEuropeanBase<HP305x223>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 305 × 223";
        public Length Height => new Length(337.9, LengthUnit.Millimeter);
        public Length Width => new Length(325.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(30.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP305x223() { }
    }
}

