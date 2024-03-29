using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x340 : SingletonEuropeanBase<UC356x406x340>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 340";
        public Length Height => new Length(406.4, LengthUnit.Millimeter);
        public Length Width => new Length(403, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(42.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x340() { }
    }
}
