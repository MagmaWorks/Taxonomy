using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE120C : SingletonEuropeanBase<HE120C>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEC;
        public override string Designation => "HE 120 C";
        public Length Height => new Length(130, LengthUnit.Millimeter);
        public Length Width => new Length(123, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE120C() { }
    }
}
