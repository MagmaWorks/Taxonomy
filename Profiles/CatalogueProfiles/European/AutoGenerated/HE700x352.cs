using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE700x352 : SingletonEuropeanBase<HE700x352>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HE;
        public override string Designation => "HE 700 × 352";
        public Length Height => new Length(728, LengthUnit.Millimeter);
        public Length Width => new Length(308, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(46, LengthUnit.Millimeter);
        public Length WebThickness => new Length(25, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE700x352() { }
    }
}
