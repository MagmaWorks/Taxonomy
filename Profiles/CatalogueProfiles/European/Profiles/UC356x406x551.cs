using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x551 : SingletonEuropeanBase<UC356x406x551>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 551";
        public Length Height => new Length(455.6, LengthUnit.Millimeter);
        public Length Width => new Length(418.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(67.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(42.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x551() { }
    }
}
