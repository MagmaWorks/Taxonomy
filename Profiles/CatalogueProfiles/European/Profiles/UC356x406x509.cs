using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x509 : SingletonEuropeanBase<UC356x406x509>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 406 × 509";
        public Length Height => new Length(446, LengthUnit.Millimeter);
        public Length Width => new Length(416, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(62.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(39.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x509() { }
    }
}
