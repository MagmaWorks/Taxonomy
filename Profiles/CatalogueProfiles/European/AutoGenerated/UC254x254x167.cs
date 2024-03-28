using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC254x254x167 : SingletonEuropeanBase<UC254x254x167>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 254 × 254 × 167";
        public Length Height => new Length(289.1, LengthUnit.Millimeter);
        public Length Width => new Length(265.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(31.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UC254x254x167() { }
    }
}

