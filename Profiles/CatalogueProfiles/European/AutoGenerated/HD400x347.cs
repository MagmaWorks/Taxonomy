using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x347 : SingletonEuropeanBase<HD400x347>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 400 × 347";
        public Length Height => new Length(407, LengthUnit.Millimeter);
        public Length Width => new Length(404, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(43.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(27.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x347() { }
    }
}

