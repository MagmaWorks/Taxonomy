using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB610x229x113 : SingletonEuropeanBase<UB610x229x113>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 610 × 229 × 113";
        public Length Height => new Length(607.6, LengthUnit.Millimeter);
        public Length Width => new Length(228.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB610x229x113() { }
    }
}
