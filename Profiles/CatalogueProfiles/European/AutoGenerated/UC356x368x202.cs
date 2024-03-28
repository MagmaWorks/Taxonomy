using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x368x202 : SingletonEuropeanBase<UC356x368x202>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 368 × 202";
        public Length Height => new Length(374.6, LengthUnit.Millimeter);
        public Length Width => new Length(374.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(27, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x368x202() { }
    }
}

