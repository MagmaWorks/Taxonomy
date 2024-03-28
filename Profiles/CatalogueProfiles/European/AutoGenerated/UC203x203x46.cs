using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC203x203x46 : SingletonEuropeanBase<UC203x203x46>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 203 × 203 × 46";
        public Length Height => new Length(203.2, LengthUnit.Millimeter);
        public Length Width => new Length(203.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UC203x203x46() { }
    }
}

