using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE550M : SingletonEuropeanBase<HE550M>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEM;
        public override string Designation => "HE 550 M";
        public Length Height => new Length(572, LengthUnit.Millimeter);
        public Length Width => new Length(306, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21, LengthUnit.Millimeter);
        public Length WebThickness => new Length(40, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE550M() { }
    }
}

