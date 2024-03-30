using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC305x305x240 : SingletonEuropeanBase<UC305x305x240>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 305 × 305 × 240";
        public Length Height => new Length(352.5, LengthUnit.Millimeter);
        public Length Width => new Length(318.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(37.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(23, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC305x305x240() { }
    }
}
