using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC305x305x118 : SingletonEuropeanBase<UC305x305x118>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 305 × 305 × 118";
        public Length Height => new Length(314.5, LengthUnit.Millimeter);
        public Length Width => new Length(307.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC305x305x118() { }
    }
}
