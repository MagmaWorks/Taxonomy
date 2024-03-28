using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD360x196 : SingletonEuropeanBase<HD360x196>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 360 × 196";
        public Length Height => new Length(372, LengthUnit.Millimeter);
        public Length Width => new Length(374, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD360x196() { }
    }
}

