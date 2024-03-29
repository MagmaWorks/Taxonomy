using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE600B : SingletonEuropeanBase<HE600B>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEB;
        public override string Designation => "HE 600 B";
        public Length Height => new Length(600, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(30, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE600B() { }
    }
}
