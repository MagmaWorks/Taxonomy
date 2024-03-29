using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x1299 : SingletonEuropeanBase<UC356x406x1299>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 1299";
        public Length Height => new Length(600, LengthUnit.Millimeter);
        public Length Width => new Length(476, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(140, LengthUnit.Millimeter);
        public Length WebThickness => new Length(100, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.4, LengthUnit.Millimeter);

        public UC356x406x1299() { }
    }
}
