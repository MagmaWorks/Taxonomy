using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE600x337 : SingletonEuropeanBase<HE600x337>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HE;
        public override string Designation => "HE 600 × 337";
        public Length Height => new Length(632, LengthUnit.Millimeter);
        public Length Width => new Length(310, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(46, LengthUnit.Millimeter);
        public Length WebThickness => new Length(25.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE600x337() { }
    }
}
