using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP305x305x149 : SingletonEuropeanBase<UBP305x305x149>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 305 × 305 × 149";
        public Length Height => new Length(318.5, LengthUnit.Millimeter);
        public Length Width => new Length(316, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP305x305x149() { }
    }
}

