using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP203x203x45 : SingletonEuropeanBase<UBP203x203x45>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 203 × 203 × 45";
        public Length Height => new Length(200.2, LengthUnit.Millimeter);
        public Length Width => new Length(205.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UBP203x203x45() { }
    }
}

