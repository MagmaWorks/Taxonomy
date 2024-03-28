using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE300A : SingletonEuropeanBase<HE300A>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEA;
        public override string Designation => "HE 300 A";
        public Length Height => new Length(290, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE300A() { }
    }
}

