using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x314 : SingletonEuropeanBase<HD400x314>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 400 × 314";
        public Length Height => new Length(399, LengthUnit.Millimeter);
        public Length Width => new Length(401, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(39.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x314() { }
    }
}

