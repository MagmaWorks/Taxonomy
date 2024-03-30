using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x382 : SingletonEuropeanBase<HD400x382>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 382";
        public Length Height => new Length(416, LengthUnit.Millimeter);
        public Length Width => new Length(406, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(48, LengthUnit.Millimeter);
        public Length WebThickness => new Length(29.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x382() { }
    }
}
