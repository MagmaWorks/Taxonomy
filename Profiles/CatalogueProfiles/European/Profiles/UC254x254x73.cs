using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC254x254x73 : SingletonEuropeanBase<UC254x254x73>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 254 × 254 × 73";
        public Length Height => new Length(254.1, LengthUnit.Millimeter);
        public Length Width => new Length(254.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UC254x254x73() { }
    }
}