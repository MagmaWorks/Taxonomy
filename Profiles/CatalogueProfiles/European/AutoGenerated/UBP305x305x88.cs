using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP305x305x88 : SingletonEuropeanBase<UBP305x305x88>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 305 × 305 × 88";
        public Length Height => new Length(301.7, LengthUnit.Millimeter);
        public Length Width => new Length(307.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP305x305x88() { }
    }
}

