using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x102x28 : SingletonEuropeanBase<UB305x102x28>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 305 × 102 × 28";
        public Length Height => new Length(308.7, LengthUnit.Millimeter);
        public Length Width => new Length(101.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB305x102x28() { }
    }
}
