using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC203x203x60 : SingletonEuropeanBase<UC203x203x60>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 203 × 203 × 60";
        public Length Height => new Length(209.6, LengthUnit.Millimeter);
        public Length Width => new Length(205.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UC203x203x60() { }
    }
}

