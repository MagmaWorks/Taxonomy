using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD360x179 : SingletonEuropeanBase<HD360x179>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 360 × 179";
        public Length Height => new Length(368, LengthUnit.Millimeter);
        public Length Width => new Length(373, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(23.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD360x179() { }
    }
}

