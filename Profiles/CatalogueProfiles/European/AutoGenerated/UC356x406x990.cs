using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x990 : SingletonEuropeanBase<UC356x406x990>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 990";
        public Length Height => new Length(550, LengthUnit.Millimeter);
        public Length Width => new Length(448, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(71.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(115, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x990() { }
    }
}

