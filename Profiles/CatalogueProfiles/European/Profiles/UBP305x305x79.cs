using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP305x305x79 : SingletonEuropeanBase<UBP305x305x79>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 305 × 305 × 79";
        public Length Height => new Length(299.3, LengthUnit.Millimeter);
        public Length Width => new Length(306.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP305x305x79() { }
    }
}
