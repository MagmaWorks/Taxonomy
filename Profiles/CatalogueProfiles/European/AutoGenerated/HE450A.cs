using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE450A : SingletonEuropeanBase<HE450A>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEA;
        public override string Designation => "HE 450 A";
        public Length Height => new Length(440, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE450A() { }
    }
}

