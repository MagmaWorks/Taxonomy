using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000B : SingletonEuropeanBase<HE1000B>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEB;
        public override string Designation => "HE 1000 B";
        public Length Height => new Length(1000, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(36, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000B() { }
    }
}
