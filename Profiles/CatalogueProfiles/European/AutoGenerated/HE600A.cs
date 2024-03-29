using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE600A : SingletonEuropeanBase<HE600A>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEA;
        public override string Designation => "HE 600 A";
        public Length Height => new Length(590, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE600A() { }
    }
}
