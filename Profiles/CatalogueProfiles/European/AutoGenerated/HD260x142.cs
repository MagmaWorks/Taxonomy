using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD260x142 : SingletonEuropeanBase<HD260x142>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 260 × 142";
        public Length Height => new Length(278, LengthUnit.Millimeter);
        public Length Width => new Length(265, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HD260x142() { }
    }
}

