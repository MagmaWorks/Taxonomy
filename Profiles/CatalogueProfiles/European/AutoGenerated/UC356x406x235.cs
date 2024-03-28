using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x235 : SingletonEuropeanBase<UC356x406x235>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 235";
        public Length Height => new Length(381, LengthUnit.Millimeter);
        public Length Width => new Length(394.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(30.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x235() { }
    }
}

