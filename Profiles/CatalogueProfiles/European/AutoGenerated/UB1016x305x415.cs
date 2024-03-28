using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB1016x305x415 : SingletonEuropeanBase<UB1016x305x415>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 1016 × 305 × 415";
        public Length Height => new Length(1020, LengthUnit.Millimeter);
        public Length Width => new Length(304, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(26, LengthUnit.Millimeter);
        public Length WebThickness => new Length(46, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public UB1016x305x415() { }
    }
}

