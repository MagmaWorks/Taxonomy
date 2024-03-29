using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE800AA : SingletonEuropeanBase<HE800AA>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEAA;
        public override string Designation => "HE 800 AA";
        public Length Height => new Length(770, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE800AA() { }
    }
}
