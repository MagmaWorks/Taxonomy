using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD260x225 : SingletonEuropeanBase<HD260x225>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 260 × 225";
        public Length Height => new Length(309, LengthUnit.Millimeter);
        public Length Width => new Length(271, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(42, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HD260x225() { }
    }
}

