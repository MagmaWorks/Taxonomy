using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB762x267x197 : SingletonEuropeanBase<UB762x267x197>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 762 × 267 × 197";
        public Length Height => new Length(769.8, LengthUnit.Millimeter);
        public Length Width => new Length(268, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public UB762x267x197() { }
    }
}

