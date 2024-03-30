using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB1016x305x584 : SingletonEuropeanBase<UB1016x305x584>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 1016 × 305 × 584";
        public Length Height => new Length(1056, LengthUnit.Millimeter);
        public Length Width => new Length(314, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(64, LengthUnit.Millimeter);
        public Length WebThickness => new Length(36, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public UB1016x305x584() { }
    }
}
