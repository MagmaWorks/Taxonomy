using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x467 : SingletonEuropeanBase<UC356x406x467>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 467";
        public Length Height => new Length(436.6, LengthUnit.Millimeter);
        public Length Width => new Length(412.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(35.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(58, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x467() { }
    }
}

