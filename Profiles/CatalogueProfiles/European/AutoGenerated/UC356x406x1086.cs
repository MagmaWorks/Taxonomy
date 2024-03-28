using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x1086 : SingletonEuropeanBase<UC356x406x1086>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 1086";
        public Length Height => new Length(569, LengthUnit.Millimeter);
        public Length Width => new Length(454, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(78, LengthUnit.Millimeter);
        public Length WebThickness => new Length(125, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x1086() { }
    }
}

