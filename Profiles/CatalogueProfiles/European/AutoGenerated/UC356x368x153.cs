using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x368x153 : SingletonEuropeanBase<UC356x368x153>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 368 × 153";
        public Length Height => new Length(362, LengthUnit.Millimeter);
        public Length Width => new Length(370.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x368x153() { }
    }
}
