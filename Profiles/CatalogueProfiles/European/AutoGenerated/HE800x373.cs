using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE800x373 : SingletonEuropeanBase<HE800x373>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HE;
        public override string Designation => "HE 800 × 373";
        public Length Height => new Length(826, LengthUnit.Millimeter);
        public Length Width => new Length(308, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25, LengthUnit.Millimeter);
        public Length WebThickness => new Length(46, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE800x373() { }
    }
}

