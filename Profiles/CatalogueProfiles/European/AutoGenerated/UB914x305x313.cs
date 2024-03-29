using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x313 : SingletonEuropeanBase<UB914x305x313>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 914 × 305 × 313";
        public Length Height => new Length(932, LengthUnit.Millimeter);
        public Length Width => new Length(309, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(34.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x313() { }
    }
}
