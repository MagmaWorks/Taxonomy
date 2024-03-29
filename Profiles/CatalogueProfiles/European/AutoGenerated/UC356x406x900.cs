using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x900 : SingletonEuropeanBase<UC356x406x900>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 900";
        public Length Height => new Length(531, LengthUnit.Millimeter);
        public Length Width => new Length(442, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(106, LengthUnit.Millimeter);
        public Length WebThickness => new Length(65.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x900() { }
    }
}
