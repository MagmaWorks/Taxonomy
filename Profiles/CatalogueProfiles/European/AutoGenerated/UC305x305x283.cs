using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC305x305x283 : SingletonEuropeanBase<UC305x305x283>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 305 × 305 × 283";
        public Length Height => new Length(365.3, LengthUnit.Millimeter);
        public Length Width => new Length(322.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(44.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC305x305x283() { }
    }
}

