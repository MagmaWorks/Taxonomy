using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE550AA : SingletonEuropeanBase<HE550AA>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEAA;
        public override string Designation => "HE 550 AA";
        public Length Height => new Length(522, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE550AA() { }
    }
}
