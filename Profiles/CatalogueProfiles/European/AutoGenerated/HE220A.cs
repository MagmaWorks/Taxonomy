using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE220A : SingletonEuropeanBase<HE220A>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEA;
        public override string Designation => "HE 220 A";
        public Length Height => new Length(210, LengthUnit.Millimeter);
        public Length Width => new Length(220, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE220A() { }
    }
}

