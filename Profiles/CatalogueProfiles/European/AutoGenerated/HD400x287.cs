using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x287 : SingletonEuropeanBase<HD400x287>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 400 × 287";
        public Length Height => new Length(393, LengthUnit.Millimeter);
        public Length Width => new Length(399, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(22.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(36.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x287() { }
    }
}

