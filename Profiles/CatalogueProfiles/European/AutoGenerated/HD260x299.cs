using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD260x299 : SingletonEuropeanBase<HD260x299>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 260 × 299";
        public Length Height => new Length(335, LengthUnit.Millimeter);
        public Length Width => new Length(278, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(55, LengthUnit.Millimeter);
        public Length WebThickness => new Length(31, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HD260x299() { }
    }
}

