using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE200AA : SingletonEuropeanBase<HE200AA>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEAA;
        public override string Designation => "HE 200 AA";
        public Length Height => new Length(186, LengthUnit.Millimeter);
        public Length Width => new Length(200, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE200AA() { }
    }
}
