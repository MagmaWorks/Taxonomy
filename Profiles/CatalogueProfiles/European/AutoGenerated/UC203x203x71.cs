using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC203x203x71 : SingletonEuropeanBase<UC203x203x71>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 203 × 203 × 71";
        public Length Height => new Length(215.8, LengthUnit.Millimeter);
        public Length Width => new Length(206.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UC203x203x71() { }
    }
}

