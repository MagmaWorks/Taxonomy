using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x744 : SingletonEuropeanBase<HD400x744>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 400 × 744";
        public Length Height => new Length(498, LengthUnit.Millimeter);
        public Length Width => new Length(432, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(55.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(88.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x744() { }
    }
}

