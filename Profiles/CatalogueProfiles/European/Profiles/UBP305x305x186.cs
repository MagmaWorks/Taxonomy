using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP305x305x186 : SingletonEuropeanBase<UBP305x305x186>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 305 × 305 × 186";
        public Length Height => new Length(328.3, LengthUnit.Millimeter);
        public Length Width => new Length(320.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(25.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP305x305x186() { }
    }
}
