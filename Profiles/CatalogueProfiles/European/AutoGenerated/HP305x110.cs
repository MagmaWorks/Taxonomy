using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP305x110 : SingletonEuropeanBase<HP305x110>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 305 × 110";
        public Length Height => new Length(307.9, LengthUnit.Millimeter);
        public Length Width => new Length(310.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP305x110() { }
    }
}

