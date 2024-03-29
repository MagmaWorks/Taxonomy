using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE700x418 : SingletonEuropeanBase<HE700x418>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HE;
        public override string Designation => "HE 700 × 418";
        public Length Height => new Length(744, LengthUnit.Millimeter);
        public Length Width => new Length(313, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(54, LengthUnit.Millimeter);
        public Length WebThickness => new Length(29.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE700x418() { }
    }
}
