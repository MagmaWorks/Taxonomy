using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP305x305x223 : SingletonEuropeanBase<UBP305x305x223>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 305 × 305 × 223";
        public Length Height => new Length(337.9, LengthUnit.Millimeter);
        public Length Width => new Length(325.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(30.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP305x305x223() { }
    }
}

