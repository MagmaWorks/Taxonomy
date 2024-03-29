using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x253 : SingletonEuropeanBase<UB914x305x253>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 914 × 305 × 253";
        public Length Height => new Length(918.4, LengthUnit.Millimeter);
        public Length Width => new Length(305.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(27.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x253() { }
    }
}
