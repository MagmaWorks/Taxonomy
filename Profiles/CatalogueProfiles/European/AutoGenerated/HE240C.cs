using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE240C : SingletonEuropeanBase<HE240C>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEC;
        public override string Designation => "HE 240 C";
        public Length Height => new Length(255, LengthUnit.Millimeter);
        public Length Width => new Length(244, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public HE240C() { }
    }
}

