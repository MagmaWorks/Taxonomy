using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE500M : SingletonEuropeanBase<HE500M>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEM;
        public override string Designation => "HE 500 M";
        public Length Height => new Length(524, LengthUnit.Millimeter);
        public Length Width => new Length(306, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(40, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE500M() { }
    }
}
