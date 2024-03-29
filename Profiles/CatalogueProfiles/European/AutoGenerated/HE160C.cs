using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE160C : SingletonEuropeanBase<HE160C>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEC;
        public override string Designation => "HE 160 C";
        public Length Height => new Length(170, LengthUnit.Millimeter);
        public Length Width => new Length(163, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE160C() { }
    }
}
