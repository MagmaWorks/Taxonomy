using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE700B : SingletonEuropeanBase<HE700B>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEB;
        public override string Designation => "HE 700 B";
        public Length Height => new Length(700, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(32, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE700B() { }
    }
}
