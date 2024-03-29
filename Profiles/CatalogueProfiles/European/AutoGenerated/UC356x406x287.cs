using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x287 : SingletonEuropeanBase<UC356x406x287>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 287";
        public Length Height => new Length(393.6, LengthUnit.Millimeter);
        public Length Width => new Length(399, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(36.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(22.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x287() { }
    }
}
