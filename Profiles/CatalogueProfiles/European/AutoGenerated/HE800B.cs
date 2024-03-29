using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE800B : SingletonEuropeanBase<HE800B>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEB;
        public override string Designation => "HE 800 B";
        public Length Height => new Length(800, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(33, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE800B() { }
    }
}
