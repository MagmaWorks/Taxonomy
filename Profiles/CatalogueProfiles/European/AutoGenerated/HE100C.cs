using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE100C : SingletonEuropeanBase<HE100C>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEC;
        public override string Designation => "HE 100 C";
        public Length Height => new Length(110, LengthUnit.Millimeter);
        public Length Width => new Length(103, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE100C() { }
    }
}
