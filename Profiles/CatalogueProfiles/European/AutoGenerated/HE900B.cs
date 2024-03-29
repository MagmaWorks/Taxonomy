using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE900B : SingletonEuropeanBase<HE900B>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEB;
        public override string Designation => "HE 900 B";
        public Length Height => new Length(900, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(35, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE900B() { }
    }
}
