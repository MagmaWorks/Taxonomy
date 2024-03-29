using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x165x54 : SingletonEuropeanBase<UB305x165x54>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 305 × 165 × 54";
        public Length Height => new Length(310.4, LengthUnit.Millimeter);
        public Length Width => new Length(166.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.9, LengthUnit.Millimeter);

        public UB305x165x54() { }
    }
}
