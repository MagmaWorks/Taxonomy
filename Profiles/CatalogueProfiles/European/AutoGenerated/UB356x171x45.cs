using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB356x171x45 : SingletonEuropeanBase<UB356x171x45>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 356 × 171 × 45";
        public Length Height => new Length(351.4, LengthUnit.Millimeter);
        public Length Width => new Length(171.1, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB356x171x45() { }
    }
}
