using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x576 : SingletonEuropeanBase<UB914x305x576>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 914 × 305 × 576";
        public Length Height => new Length(993, LengthUnit.Millimeter);
        public Length Width => new Length(322, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(65, LengthUnit.Millimeter);
        public Length WebThickness => new Length(36.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x576() { }
    }
}

