using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB762x267x134 : SingletonEuropeanBase<UB762x267x134>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 762 × 267 × 134";
        public Length Height => new Length(750, LengthUnit.Millimeter);
        public Length Width => new Length(264.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public UB762x267x134() { }
    }
}
