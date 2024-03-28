using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB406x178x60 : SingletonEuropeanBase<UB406x178x60>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 406 × 178 × 60";
        public Length Height => new Length(406.4, LengthUnit.Millimeter);
        public Length Width => new Length(177.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB406x178x60() { }
    }
}

