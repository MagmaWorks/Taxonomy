using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB406x178x54 : SingletonEuropeanBase<UB406x178x54>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 406 × 178 × 54";
        public Length Height => new Length(402.6, LengthUnit.Millimeter);
        public Length Width => new Length(177.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB406x178x54() { }
    }
}

