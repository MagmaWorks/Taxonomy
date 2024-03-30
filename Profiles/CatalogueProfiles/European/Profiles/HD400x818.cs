using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x818 : SingletonEuropeanBase<HD400x818>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 400 × 818";
        public Length Height => new Length(514, LengthUnit.Millimeter);
        public Length Width => new Length(437, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(97, LengthUnit.Millimeter);
        public Length WebThickness => new Length(60.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x818() { }
    }
}
