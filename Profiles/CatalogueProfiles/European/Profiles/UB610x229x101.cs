using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB610x229x101 : SingletonEuropeanBase<UB610x229x101>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 610 × 229 × 101";
        public Length Height => new Length(602.6, LengthUnit.Millimeter);
        public Length Width => new Length(227.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB610x229x101() { }
    }
}
