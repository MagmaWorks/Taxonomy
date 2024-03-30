using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x1202 : SingletonEuropeanBase<UC356x406x1202>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 1202";
        public Length Height => new Length(580, LengthUnit.Millimeter);
        public Length Width => new Length(471, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(130, LengthUnit.Millimeter);
        public Length WebThickness => new Length(95, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.4, LengthUnit.Millimeter);

        public UC356x406x1202() { }
    }
}
