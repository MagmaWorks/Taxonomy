using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000x584 : SingletonEuropeanBase<HE1000x584>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HE;
        public override string Designation => "HE 1000 × 584";
        public Length Height => new Length(1056, LengthUnit.Millimeter);
        public Length Width => new Length(314, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(36, LengthUnit.Millimeter);
        public Length WebThickness => new Length(64, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000x584() { }
    }
}

